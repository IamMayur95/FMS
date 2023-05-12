using System;

namespace Utils.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SimpleIndexAttribute : Attribute
    {
        public bool IsUnique { get; set; } = false;
    }
}
