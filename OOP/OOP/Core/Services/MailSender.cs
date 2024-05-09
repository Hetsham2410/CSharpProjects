using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class MailSender
    {
        public void Send(string to, string subject, string body)
        {
            var logger = new Logger();
            logger.LogMessage($"Sending an email to '{to}'");
        }
        
    }
}
