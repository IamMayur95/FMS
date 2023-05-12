using FMS.Entities.Models.Base;

namespace FMS.Entities.Models
{
    public class User : BaseAuditableModel
    {
        public string EmployeeId { get; set; }

        public string FullName { get; set; }

        public string CompanyEmailId { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public bool IsActive { get; set; }
    }
}
