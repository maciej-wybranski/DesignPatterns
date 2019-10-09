using System;
using System.Collections.Generic;

namespace DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender sms = new SmsSender();
            IMessageSender webService = new WebServiceSender();

            Message message = new SystemMessage()
            {
                Subject = "System message",
                Body = "Test system message"
            };


            message.MessageSender = email;
            message.Send();

            //Sending the same message via all Message Sender
            Console.WriteLine($"\n\nSending the same message via all message sender.\n");
            HashSet<IMessageSender> messageSenders = new HashSet<IMessageSender>
            {
                email,
                sms,
                webService
            };
            foreach(var item in messageSenders)
            {
                message.MessageSender = item;
                message.Send();

            }
        }
    }
}
