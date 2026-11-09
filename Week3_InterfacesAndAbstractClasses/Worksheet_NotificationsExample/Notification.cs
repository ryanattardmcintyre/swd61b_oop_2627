using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_NotificationsExample
{
    public abstract class Notification
    {
        public List<Subscriber> Subscribers { get; set; }
        public string Message { get; set; }

        public Notification(string message)
        {
            Message = message;
          Subscribers = new List<Subscriber>(); //instantiation of a List<...> object
        }

        public void AddSubscriber(Subscriber s)
        {
            Subscribers.Add(s);
        }

        public void RemoveSubscriber(Subscriber s) {
            Subscribers.Remove(s);
        }

        public void RemoveSubscriber(int id)
        {
            /*foreach(var s in Subscribers)
            {
                if (s.Id == id) { Subscribers.Remove(s); break; }
            }*/

            var subscriberToRemove = Subscribers.SingleOrDefault(s => s.Id == id);
            Subscribers.Remove(subscriberToRemove);
        }

        public void NotifySubscribers() {
            foreach (var s in Subscribers)
            {
                Send(s);
            }
        }
        public abstract void Send(Subscriber subscriber);
    }
}
