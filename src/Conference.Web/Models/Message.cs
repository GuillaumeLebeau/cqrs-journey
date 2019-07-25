using System;

namespace Conference.Web.Models
{
    public class Message
    {
        public MessageFrom From { get; set; }

        public string Sub { get; set; }

        public string Content { get; set; }

        public DateTime SentAt { get; set; }
    }
}
