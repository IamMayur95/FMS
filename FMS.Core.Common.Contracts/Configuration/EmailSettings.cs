namespace FMS.Core.Common.Contracts.Configuration
{
    public class EmailSettings
    {
        public string HostName { get; set; }
        public string PortNumber { get; set; }
        public string FromEmail { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
