using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example5
{
    /*
     * Notification =>
     *      properties => message, date, sender, recipient
     *      methods => 1) Send() =>Console.WriteLine(...) 2) Send(Tag)
     *      enum => Tag is an enum which contains the following: Information, Error, Warning
     *      constructors => 1) default constructor; 2) one which asks for message, recipient and sender
     * 
     * LogNotification =>
     *      properties => same as above + filename of log (extension: .log)
     *      methods => 1) override the above methods to write into file with filename ending with .log
     *      
     */ 

    public enum TagType { Information, Error, Warning};
    public class Notification
    {
        public Notification()
        { Tag = TagType.Information;  }

        public TagType Tag { get; set; }

        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }

        public virtual void Send()
        {
            Console.WriteLine($"{Tag} - {DateSent}: Sender {Sender} sends {Message} to Recipient: {Recipient}");

        }

        public virtual void Send(TagType tag)
        {
            Tag = tag;
            Console.WriteLine($"{tag} - {DateSent}: Sender {Sender} sends {Message} to Recipient: {Recipient}");
        }
    }
}
