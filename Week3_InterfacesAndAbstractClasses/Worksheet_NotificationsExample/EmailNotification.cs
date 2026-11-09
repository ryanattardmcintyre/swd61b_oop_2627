using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_NotificationsExample
{
    public class EmailNotification: Notification
    {
        public EmailNotification(string subject, string message ) : base(message)
        {
            Subject = subject;
        }
        public string Subject { get; set; }
        public override void Send(Subscriber subscriber)
        {
            MailMessage message = new MailMessage("ryan.attard@mcast.edu.mt", 
                subscriber.Email);
            message.Subject = Subject;
            message.Body = Message;

            NetworkCredential credential = new NetworkCredential("username", "password");
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = credential;

            smtpClient.Send(message);
        }
    }
}
