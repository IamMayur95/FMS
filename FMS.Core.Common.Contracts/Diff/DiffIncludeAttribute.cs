using System;

namespace FMS.Core.Common.Contracts.Diff
{
    /// <summary>
    /// Attribute used to mark properties that should be included during diff operation
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DiffIncludeAttribute : Attribute
    {
    }
}
