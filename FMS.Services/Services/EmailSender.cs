using FMS.Core.Common.Contracts.Configuration;
using FMS.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Services.Services
{
    public class EmailSender
    {
        private readonly EmailSettings _settings;

        public EmailSender(EmailSettings settings)
        {
            _settings = settings;
        }

        public async Task SendEmailAsync(List<string> emails, List<string> ccEmails, string subject, string htmlMessage)
        {

            using (SmtpClient client = new SmtpClient())
            {
                if (emails?.Count > 0)
                {
                    NetworkCredential credential = new NetworkCredential("o" + _settings.UserName, _settings.Password);
                    using (MailMessage message = new MailMessage())
                    {
                        client.Host = _settings.HostName;
                        client.Port = int.Parse(_settings.PortNumber);
                        client.UseDefaultCredentials = false;
                        client.Credentials = (ICredentialsByHost)credential;
                        message.From = new MailAddress(_settings.FromEmail);
                        message.Subject = subject;
                        message.IsBodyHtml = true;
                        message.Body = htmlMessage;
                        foreach (var email in emails)
                        {
                            message.To.Add(new MailAddress(email));
                        }
                        try
                        {
                            client.Send(message);
                        }
                        catch (Exception exception1)
                        {
                            throw exception1;
                        }
                    }
                }
            }
        }

        public async Task SendEmailWithAttachmentAsync(EmailDTO emailDTO)
        {
            using (SmtpClient client = new SmtpClient())
            {
                if (emailDTO.To?.Count > 0)
                {
                    NetworkCredential credential = new NetworkCredential("o" + _settings.UserName, _settings.Password);

                    System.Net.Mime.ContentType contentType;
                    Attachment attachment;

                    using (MailMessage message = new MailMessage())
                    {
                        client.Host = _settings.HostName;
                        client.Port = int.Parse(_settings.PortNumber);
                        client.UseDefaultCredentials = false;
                        client.Credentials = (ICredentialsByHost)credential;
                        message.From = new MailAddress(_settings.FromEmail);
                        message.Subject = emailDTO.Subject;
                        message.IsBodyHtml = false;
                        message.BodyEncoding = Encoding.UTF8;
                        message.BodyTransferEncoding = System.Net.Mime.TransferEncoding.EightBit;
                        message.Body = emailDTO.Body;

                        if (emailDTO.Attachment.FileType == "image")
                        {
                            byte[] imageBytes = Convert.FromBase64String(emailDTO.Attachment.ContentAsBase64);
                            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

                            attachment = new Attachment(ms, emailDTO.Attachment.FileName);
                            attachment.TransferEncoding = TransferEncoding.Base64;
                        }
                        else
                        {
                            contentType = new System.Net.Mime.ContentType("application/vnd.ms-excel");
                            attachment = new Attachment(new MemoryStream(System.Convert.FromBase64String(emailDTO.Attachment.ContentAsBase64)), contentType);
                            attachment.Name = emailDTO.Attachment.FileName;
                        }

                        message.Attachments.Add(attachment);
                        foreach (var email in emailDTO.To)
                        {
                            message.To.Add(new MailAddress(email));
                        }
                        try
                        {
                            client.Send(message);
                        }
                        catch (Exception exception1)
                        {
                            throw exception1;
                        }
                    }
                }
            }
        }
    }
}
