namespace FMS.Entities.DTOs
{
    public class EmailAttachmentDTO
    {
        public string FileType { get; set; }
        public string FileFormat { get; set; }
        public string ContentAsBase64 { get; set; }
        public byte[] ContentAsByteArray { get; set; }
        public string FileName { get; set; }
    }
}
