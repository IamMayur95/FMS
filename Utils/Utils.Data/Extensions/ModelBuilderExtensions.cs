using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Utils.Data.Attributes;

namespace Utils.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder RemoveCascadeDeleteConvention(this ModelBuilder @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (@this.Model == null)
                return @this;

            var cascadeFKs = @this.Model.GetEntityTypes()
                            .SelectMany(t => t.GetForeignKeys())
                            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            return @this;
        }

        public static ModelBuilder ApplyDecimalPrecision(this ModelBuilder @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (@this.Model == null)
                return @this;

            foreach (var entity in @this.Model.GetEntityTypes())
            {
                foreach (var prop in entity.GetProperties())
                {
                    if (prop?.PropertyInfo is not null)
                    {
                        var attr = prop.PropertyInfo.GetCustomAttribute<DecimalPrecisionAttribute>();
                        if (attr is not null)
                        {
                            if (prop.ClrType != typeof(decimal) && prop.ClrType != typeof(decimal?))
                            {
                                throw new InvalidOperationException($"Attribute '{nameof(DecimalPrecisionAttribute)}' can only by applied to property of type 'decimal/decimal?'. Property '{prop.Name}' is of type '{prop.GetType().Name}'");
                            }

                            if (attr.Precision < 1 || attr.Precision > 38)
                            {
                                throw new InvalidOperationException("Precision must be between 1 and 38.");
                            }

                            if (attr.Scale > attr.Precision)
                            {
                                throw new InvalidOperationException("Scale must be between 0 and the Precision value.");
                            }

                            var sqlServerType = $"decimal({attr.Precision}, {attr.Scale})";
                            prop.SetColumnType(sqlServerType);
                        }
                    }
                }
            }

            return @this;
        }

        public static ModelBuilder ApplySimpleIndex(this ModelBuilder @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (@this.Model == null)
                return @this;

            foreach (var entity in @this.Model.GetEntityTypes())
            {
                foreach (var prop in entity.GetProperties())
                {
                    if (prop?.PropertyInfo is not null)
                    {
                        var attr = prop.PropertyInfo.GetCustomAttribute<SimpleIndexAttribute>();
                        if (attr is not null)
                        {
                            var index = entity.AddIndex(prop);
                            index.IsUnique = attr.IsUnique;
                        }
                    }
                }
            }

            return @this;
        }
    }
}
