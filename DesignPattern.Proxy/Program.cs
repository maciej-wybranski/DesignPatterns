using DesignPattern.Bridge;
using System;

namespace DesignPattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new UserMessage()
            {
                Subject = "Proxy design pattern",
                Body = "I'm testing the proxy design pattern",
                UserComments = "Is it working? .... I hope so."
            };

            IMessageSender messageSender = new MultiSender();
            message.MessageSender = messageSender;
            message.Send();
        }
    }
}
