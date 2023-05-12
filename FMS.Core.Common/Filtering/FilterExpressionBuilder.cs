using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FMS.Core.Common.Contracts.Grid.Dtos;
using FMS.Core.Common.Contracts.Grid.Enums;

namespace FMS.Core.Common.Filtering
{
    public class FilterExpressionBuilder
    {
        #region Fields

        private readonly MethodInfo _containsInfo;
        private readonly MethodInfo _startWithInfo;
        private readonly MethodInfo _endswithInfo;

        #endregion

        public FilterExpressionBuilder()
        {
            _containsInfo = typeof(string).GetMethod(nameof(string.Contains), new Type[] { typeof(string) });
            _startWithInfo = typeof(string).GetMethod(nameof(string.StartsWith), new Type[] { typeof(string) });
            _endswithInfo = typeof(string).GetMethod(nameof(string.EndsWith), new Type[] { typeof(string) });
        }

        public Expression<Func<T, bool>> BuildLambda<T>(PredicateNodeDto predicateNode)
        {
            Expression<Func<T, bool>> resultExp = t => true;
            if (predicateNode == null)
            {
                return resultExp;
            }

            var parameterExp = Expression.Parameter(typeof(T), "i"); // "i" can be anything
            var predicateExp = BuildNodeExpression<T>(predicateNode, parameterExp);

            var lambda = Expression.Lambda<Func<T, bool>>(predicateExp, parameterExp);
            return lambda;
        }

        #region Utils

        public object ChangeType(object value, Type targetType)
        {
            if (value == null || targetType == null)
                return null;

            var valueType = value.GetType();

            if (valueType == typeof(long) && targetType != typeof(long))
            {
                var l = (long)value;
                value = unchecked((int)l);
            }
            else if (valueType == typeof(ulong) && targetType != typeof(long) && targetType != typeof(ulong))
            {
                var l = (ulong)value;
                value = unchecked((uint)l);
            }
            else if (valueType == typeof(double) && targetType == typeof(float))
            {
                var d = (double)value;
                value = unchecked((float)d);
            }
            else if (targetType == typeof(Guid))
            {
                if (!Guid.TryParse(value.ToString(), out var guid))
                    guid = Guid.Empty;

                value = guid;
            }

            var realTargeType = Nullable.GetUnderlyingType(targetType) ?? targetType;
            value = Convert.ChangeType(value, realTargeType);

            return value;
        }

        private bool NeedsValue(PredicateType type)
        {
            return !new PredicateType[] { PredicateType.True, PredicateType.False, PredicateType.IsNull, PredicateType.IsNotNull }.Contains(type);
        }

        private bool IsStringOperation(PredicateType type)
        {
            return new PredicateType[] { PredicateType.Contains, PredicateType.DoesNotContain, PredicateType.StartsWith, PredicateType.EndsWith }.Contains(type);
        }

        private bool IsNumericType(Type type)
        {
            return type is not null && new Type[]
            {
                typeof(short),
                typeof(ushort),
                typeof(int),
                typeof(uint),
                typeof(long),
                typeof(ulong),
                typeof(float),
                typeof(double),
                typeof(decimal)
            }.Contains(type);
        }

        private (MemberExpression, PropertyInfo) GetLastLevelPropertyInfo(string propertyName, Type firstLevelType, Expression currentMember)
        {
            // recursive: we want the last level of something like 'property1.property2.property3'
            
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            if (firstLevelType == null)
            {
                throw new ArgumentNullException(nameof(firstLevelType));
            }

            if (currentMember == null)
            {
                throw new ArgumentNullException(nameof(currentMember));
            }

            var nestedDereferencings = propertyName.Split('.');
            var firstLevelPropertyName = nestedDereferencings[0];

            var propertyInfoList = firstLevelType.GetProperties()
                .Where(p => string.Equals(p.Name, firstLevelPropertyName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var propertyInfo = default(PropertyInfo);
            switch (propertyInfoList.Count)
            {
                case 0:
                    throw new ArgumentException($"Type {firstLevelType.Name} has no property named '{firstLevelPropertyName}'");

                case 1:
                    propertyInfo = propertyInfoList[0];
                    break;

                default:
                    propertyInfo = propertyInfoList.FirstOrDefault(p => p.DeclaringType == firstLevelType)
                        ?? throw new ArgumentException($"Type {firstLevelType.Name} has {propertyInfoList.Count} property named '{firstLevelPropertyName}' due to case differences. That cannot be handled.");
                    break;
            }

            var member = Expression.Property(currentMember, propertyInfo);
            if (nestedDereferencings.Length > 1)
            {
                (member, propertyInfo) = GetLastLevelPropertyInfo(string.Join(".", nestedDereferencings.Skip(1)), propertyInfo.PropertyType, member);
            }

            return (member, propertyInfo);
        }

       // private Expression GetNeutralConstant(LogicalOperator op) => Expression.Constant(op == LogicalOperator.And || op == LogicalOperator.NotAnd);

        private Expression BuildNodeExpression<T>(PredicateNodeDto predicateNode, ParameterExpression parameterExp)
        {
            if ((predicateNode?.Nodes?.Count ?? 0) == 0 && (predicateNode?.Leaves?.Count ?? 0) == 0)
            {
                return Expression.Constant(true);
                //return GetNeutralConstant(predicateNode?.Operator ?? LogicalOperator.And);
            }

            var allExp = (predicateNode.Nodes?.Select(n => this.BuildNodeExpression<T>(n, parameterExp)) ?? Enumerable.Empty<Expression>())
                .Union(predicateNode.Leaves?.Select(n => this.BuildLeafExpression<T>(n, parameterExp)) ?? Enumerable.Empty<Expression>())
                .ToList();

            Expression resultExp;
            switch (predicateNode.Operator)
            {
                case LogicalOperator.And:
                    resultExp = allExp.Aggregate((acc, e) => Expression.AndAlso(acc, e));
                    break;

                case LogicalOperator.Or:
                    resultExp = allExp.Aggregate((acc, e) => Expression.OrElse(acc, e));
                    break;

                case LogicalOperator.NotAnd:
                    resultExp = allExp.Aggregate((acc, e) => Expression.AndAlso(acc, e));
                    resultExp = Expression.Not(resultExp);
                    break;

                case LogicalOperator.NotOr:
                    resultExp = allExp.Aggregate((acc, e) => Expression.OrElse(acc, e));
                    resultExp = Expression.Not(resultExp);
                    break;

                default:
                    throw new NotImplementedException($"{nameof(PredicateNodeDto.Operator)} with value '{predicateNode.Operator.ToString()}' not implemented");
            }

            return resultExp;
        }

        private Expression BuildLeafExpression<T>(PredicateLeafDto leaf, ParameterExpression parameterExp)
        {
            if (leaf == null || string.IsNullOrWhiteSpace(leaf.PropertyName))
            {
                return Expression.Constant(true);
            }

            var propertyInfoList = typeof(T).GetProperties()
                .Where(p => string.Equals(p.Name, leaf.PropertyName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            var (propertyExp, lastLevelPropertyInfo) = GetLastLevelPropertyInfo(leaf.PropertyName, typeof(T), parameterExp);

            #region Handle type mismatches
            if (lastLevelPropertyInfo.PropertyType.IsEnum && (leaf.Value == null || !leaf.Value.GetType().IsEnum))
            {
                if (!Enum.TryParse(lastLevelPropertyInfo.PropertyType, leaf.Value?.ToString(), out var value))
                {
                    // will force "False" predicate and avoid trying to set the property value to an undefined enum
                    value = null;
                }

                // enums might be passed as strings. Override with strongly typed enum value.
                leaf.Value = value;

                if (leaf.Value == null)
                {
                    leaf.Predicate = PredicateType.False;
                }
                else if (IsStringOperation(leaf.Predicate))
                {
                    leaf.Predicate = leaf.Predicate == PredicateType.DoesNotContain
                        ? PredicateType.DoesNotEqual
                        : PredicateType.Equals;
                }
            }
            else if (IsStringOperation(leaf.Predicate))
            {
                if (IsNumericType(lastLevelPropertyInfo.PropertyType))
                {
                    leaf.Predicate = leaf.Predicate == PredicateType.DoesNotContain
                        ? PredicateType.DoesNotEqual
                        : PredicateType.Equals;
                }
                else if (lastLevelPropertyInfo.PropertyType != typeof(string))
                {
                    leaf.Predicate = PredicateType.False;
                }
            }
            #endregion

            #region Type value
            ConstantExpression valueExp = null;
            if (NeedsValue(leaf.Predicate))
            {
                try
                {
                    var constant = this.ChangeType(leaf.Value, lastLevelPropertyInfo.PropertyType);
                    valueExp = Expression.Constant(constant, lastLevelPropertyInfo.PropertyType);
                }
                catch
                {
                    leaf.Predicate = PredicateType.False;
                }
            }
            #endregion

            #region Expression building
            Expression resultExp;
            switch (leaf.Predicate)
            {
                case PredicateType.True:
                    resultExp = Expression.Constant(true, typeof(bool));
                    break;

                case PredicateType.False:
                    resultExp = Expression.Constant(false, typeof(bool));
                    break;

                case PredicateType.Equals:
                    resultExp = Expression.Equal(propertyExp, valueExp);
                    break;

                case PredicateType.DoesNotEqual:
                    resultExp = Expression.NotEqual(propertyExp, valueExp);
                    break;

                case PredicateType.Contains:
                    resultExp = Expression.Call(propertyExp, _containsInfo, valueExp);
                    break;

                case PredicateType.DoesNotContain:
                    resultExp = Expression.Not(Expression.Call(propertyExp, _containsInfo, valueExp));
                    break;

                case PredicateType.StartsWith:
                    resultExp = Expression.Call(propertyExp, _startWithInfo, valueExp);
                    break;

                case PredicateType.EndsWith:
                    resultExp = Expression.Call(propertyExp, _endswithInfo, valueExp);
                    break;

                case PredicateType.IsNull:
                    if (lastLevelPropertyInfo.PropertyType.IsClass)
                    {
                        var nullExp = Expression.Constant(null, lastLevelPropertyInfo.PropertyType);
                        resultExp = Expression.Equal(propertyExp, nullExp);
                    }
                    else
                    {
                        resultExp = Expression.Constant(false, typeof(bool));
                    }
                    break;

                case PredicateType.IsNotNull:
                    if (lastLevelPropertyInfo.PropertyType.IsClass || Nullable.GetUnderlyingType(lastLevelPropertyInfo.PropertyType) is not null)
                    {
                        var nullExp = Expression.Constant(null, lastLevelPropertyInfo.PropertyType);
                        resultExp = Expression.NotEqual(propertyExp, nullExp);
                    }
                    else
                    {
                        resultExp = Expression.Constant(true, typeof(bool));
                    }
                    break;

                case PredicateType.LessThan:
                    resultExp = Expression.LessThan(propertyExp, valueExp);
                    break;

                case PredicateType.LessThanOrEqual:
                    resultExp = Expression.LessThanOrEqual(propertyExp, valueExp);
                    break;

                case PredicateType.GreaterThan:
                    resultExp = Expression.GreaterThan(propertyExp, valueExp);
                    break;

                case PredicateType.GreaterThanOrEqual:
                    resultExp = Expression.GreaterThanOrEqual(propertyExp, valueExp);
                    break;

                default:
                    throw new NotImplementedException($"{nameof(PredicateLeafDto.Predicate)} with value '{leaf.Predicate.ToString()}' not implemented");
            }
            #endregion

            return resultExp;
        }

        #endregion
    }
}
