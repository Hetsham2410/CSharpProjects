using OOPHRSystem.Core.Entities;
using OOPHRSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    class Notifier : INotifier
    {
        public Notifier(Sender sender)
        {
            SmtpServer = sender.smtpServer;
            Port = sender.port;
            SenderAddress = sender.senderAddress;
            SenderPassword = sender.senderPassword;
        }

        public string SmtpServer { get; }
        public int Port { get; }
        public string SenderAddress { get; }
        public string SenderPassword { get; }

        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You 've a new E-mail from'{SenderAddress}' with subject '{subject}'");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent successfully to '{email}'");
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
