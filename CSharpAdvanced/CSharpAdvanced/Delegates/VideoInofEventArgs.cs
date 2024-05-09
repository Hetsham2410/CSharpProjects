using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class VideoInofEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
