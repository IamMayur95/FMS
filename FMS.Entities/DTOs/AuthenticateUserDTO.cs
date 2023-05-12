using System;

namespace FMS.Entities.DTOs
{
    public class AuthenticateUserDTO
    {

        public string Token { get; set; }

        public UserDTO User { get; set; }

        public DateTime? TokenExpirationDateTime { get; set; }
    }
}
