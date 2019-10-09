using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class EmailSender : IMessageSender
    {
        /// <summary>
        /// The 'Concrete Implementor' class
        /// </summary>
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email: \n{subject}\n{body}");
        }
    }
}
