using FMS.Entities.Models.Base;

namespace FMS.Entities.Models
{
    public class AdminConfiguration : BaseAuditableModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
