using System;

namespace DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender sms = new SmsSender();
            IMessageSender webService = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "System message";
            message.Body = "Test system message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = sms;
            message.Send();

            message.MessageSender = webService;
            message.Send();

        }
    }
}
