using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Subscriber
    {
        public Subscriber(string subscribername)
        {
            Subscribername = subscribername;
        }

        public string Subscribername { get; }

        public void Subscribe(YoutubeChannel channel)
        {
            channel.VideoUpload += WatchVideo;
        }
        public void WatchVideo (object sender, VideoInofEventArgs videoinfo)
        {
            
            Console.WriteLine($"User {Subscribername} Watched video {videoinfo.Title} with Description {videoinfo.Description} and Duration {videoinfo.Duration}");
        }
    }
}
