using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal interface INotifier
    {
        void Notify(string email, string subject, string body);
    }
}
