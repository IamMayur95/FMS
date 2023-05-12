namespace FMS.Core.Common.Contracts.Diff
{
    public class DiffFieldChange
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }

        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public byte[] OldDistributableValue { get; set; }
        public byte[] NewDistributableValue { get; set; }

    }
}
