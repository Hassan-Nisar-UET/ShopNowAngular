using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ShopNowAngular.Emails
{
    public interface IEmailAppService
    {
        Task<(bool, string)> SendEmailGeneric(MailMessage mailMessage);
        string CreateAuthenticationEmailHtmlContent(string otp);
        Task<MailMessage> CreateEmailContent(List<string> recipientEmails, string subject, string body);

    }
}
