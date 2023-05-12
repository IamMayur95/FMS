namespace FMS.Entities.DTOs
{
    public class ImportUserDTO
    {
        public string Employee_Id { get; set; }

        public string Full_Name { get; set; }

        public string Company_Email_Id { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
