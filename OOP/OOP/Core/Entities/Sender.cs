using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    public class Sender
    {
        public string smtpServer { get; set; }
        public int port { get; set; }
        public string senderAddress { get; set; }
        public string senderPassword { get; set; }
    }
}
