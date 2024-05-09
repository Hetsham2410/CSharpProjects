using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class Logger
    {
        public void LogMessage(string message)
        {
            using (var stream = new StreamWriter("Log.txt", true))
            {
                stream.WriteLine(message);
            }
        }
    }
}
