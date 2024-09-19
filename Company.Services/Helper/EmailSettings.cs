using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Helper
{
    public class EmailSettings
    {
        public string To { get; set; }
         public string Body { get; set; }
         public string Subject { get; set; }

        public static void SendEmail(EmailSettings email)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("hamodeabdou@gmail.com");
                mail.To.Add(email.To);
                mail.Subject = email.Subject;
                mail.Body = email.Body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("hamodeabdou@gmail.com", "lomstzqptuxfwvjc");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }


            }
        }
       
    }
}
