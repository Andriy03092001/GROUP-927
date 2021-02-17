using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Work_with_Hangfire.Helper
{
    public static class SendEmail
    {
        public static void SendMail(string message, string to, string from)
        {
            string server = "smtp.gmail.com";
            MailMessage send_message = new MailMessage(from, to,"Spam", message);
            SmtpClient client = new SmtpClient(server);
            client.Port = 587; 
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("cuanid236316@gmail.com", "gmail_password");
            client.SendAsync(send_message, "blabla");
        }
    }
}