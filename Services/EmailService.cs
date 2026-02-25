using System;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace RightSupplier.Services
{
    public class EmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService(IConfiguration configuration)
        {
            var smtpSettings = configuration.GetSection("SmtpSettings");
            _smtpClient = new SmtpClient(smtpSettings["Host"], int.Parse(smtpSettings["Port"]))
            {
                Credentials = new NetworkCredential(smtpSettings["Username"], smtpSettings["Password"]),
                EnableSsl = bool.Parse(smtpSettings["EnableSsl"])
            };
        }

        public void SendEmail(string to, string subject, string body)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("no-reply@rightsupplier.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(to);

            _smtpClient.Send(mailMessage);
        }
    }
}