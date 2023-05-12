using System;

namespace FMS.Core.Common.Contracts.Configuration
{
    public class ApplicationSettings
    {
        public string ClientUrl { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public bool RequireHttpsMetadata { get; set; }
        public string ApiUrl { get; set; }
        public string UserDomain { get; set; }
        public string ITGRCEmailAddress { get; set; }
        public DateTime LiveDate { get; set; }

        public EmailSettings EmailSettings { get; set; }
    }
}
