using System;
using System.Collections.Concurrent;

namespace Conference.Web.Models
{
    public interface IChat
    {
        ConcurrentStack<Message> AllMessages { get; }

        Message AddMessage(Message message);

        IObservable<Message> Messages(string user);

        Message AddMessage(ReceivedMessage message);
    }
}
