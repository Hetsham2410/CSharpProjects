using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class NotifierFactory
    {
        public static INotifier Create(Sender sender)
        {
            return new Notifier(sender);
        }
    }
}
