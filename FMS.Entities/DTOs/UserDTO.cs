namespace FMS.Entities.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; }

        public string FullName { get; set; }

        public string CompanyEmailId { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public bool IsActive { get; set; }
    }

}
