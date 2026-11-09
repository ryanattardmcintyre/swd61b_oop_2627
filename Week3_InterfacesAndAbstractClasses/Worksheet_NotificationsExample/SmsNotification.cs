using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_NotificationsExample
{
    public class SmsNotification: Notification
    {
        public string SenderName { get; set; }
        public SmsNotification(string senderName, string message):base(message)
        {
            SenderName = senderName;
        }

        public override void Send(Subscriber subscriber)
        {
            string accountSid = "YOUR_ACCOUNT_SID";
            string authToken = "YOUR_AUTH_TOKEN";
            string fromNumber = "+1234567890";

            TwilioClient.Init(accountSid, authToken);

            var result = MessageResource.Create(
                body: Message,
                from: new PhoneNumber(fromNumber),
                to: new PhoneNumber(subscriber.Mobile)
            );

        }
    }
}
