namespace FMS.Entities.DTOs
{
    public class UserContactDetailsDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PermissionGroupName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
