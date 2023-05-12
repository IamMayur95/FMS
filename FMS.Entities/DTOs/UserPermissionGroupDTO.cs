namespace FMS.Entities.DTOs
{
    public class UserPermissionGroupDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual UserDTO User { get; set; }
        public int PermissionGroupId { get; set; }
        public virtual PermissionGroupDTO PermissionGroup { get; set; }
        public string PhoneNumber { get; set; }
    }
}
