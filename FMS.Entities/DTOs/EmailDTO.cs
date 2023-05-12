using System.Collections.Generic;

namespace FMS.Entities.DTOs
{
    public class EmailDTO
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> CC { get; set; }
        public List<string> BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public EmailAttachmentDTO Attachment { get; set; }
    }
}
