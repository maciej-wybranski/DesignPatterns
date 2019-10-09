using DesignPattern.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    class MultiSender : IMessageSender
    {
        private HashSet<IMessageSender> _messageSenders;

        public void SendMessage(string subject, string body)
        {
            if (_messageSenders == null)
            {
                _messageSenders = new HashSet<IMessageSender>
                {
                    new EmailSender(),
                    new SmsSender(),
                    new WebServiceSender()
                };
            }
            foreach(var messageSender in _messageSenders)
            {
                messageSender.SendMessage(subject, body);
            }
        }
    }
}
