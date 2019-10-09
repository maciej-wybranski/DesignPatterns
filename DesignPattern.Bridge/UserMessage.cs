using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// <summary>
    /// The 'Refined Abstraction' class
    /// </summary>
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string newBody = string.Format($"{Body}\nUser Comments: {UserComments}");
            MessageSender.SendMessage(Subject, newBody);
        }
    }
}
