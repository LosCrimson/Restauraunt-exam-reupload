using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using Restaurant.Interfaces;

namespace Restaurant.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string emailBody, string emailTo)
        {
            //https://ethereal.email/ was used for this project. 
            //host smtp.ethereal.email
            // port 587
            //userName: earl.labadie@ethereal.email
            //password: Qy1CeM7vjPqRkJ1F8V
            try
            {
                var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("earl.labadie@ethereal.email"));
         
                email.To.Add(MailboxAddress.Parse(emailTo));
         
            
            email.Subject = "Restaurant Check";
            email.Body = new TextPart(TextFormat.Plain) { Text = emailBody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("earl.labadie@ethereal.email", "Qy1CeM7vjPqRkJ1F8V");
            smtp.Send(email);
            smtp.Disconnect(true);
            }
            catch { }
        }
    }
}
