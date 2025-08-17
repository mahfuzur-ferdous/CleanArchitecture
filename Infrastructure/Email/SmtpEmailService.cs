using System.Net;
using System.Net.Mail;
using Application.Interfaces.Infrastructure;

namespace Infrastructure.Email
{
    public class SmtpEmailService : IEmailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly string _fromAddress;

        public SmtpEmailService(string host, int port, string username, string password, string fromAddress)
        {
            _fromAddress = fromAddress;

            _smtpClient = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true
            };
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var mailMessage = new MailMessage(_fromAddress, to, subject, body);
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
