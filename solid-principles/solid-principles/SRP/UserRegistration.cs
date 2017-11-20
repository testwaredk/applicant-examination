using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace solid_principles.SRP
{
    public class UserRegistration
    {
        SmtpClient _smtpClient;

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Thats not an email address");
            var user = new User(email, password);

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }   

}
