namespace FMS.Core.Common.Utils
{
    public class StringValueAttribute : System.Attribute
    {
        private readonly string _value;

        public StringValueAttribute(string value) => _value = value;

        public string Value => _value;
    }
}
