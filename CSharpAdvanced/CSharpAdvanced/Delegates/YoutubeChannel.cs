using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //public delegate void VideoUploadEventHandler(string title);
    public class YoutubeChannel
    {

        public string ChannelName { get; set; }
        public VideoInofEventArgs EnterVideoInfo(String tittle, string description, int duration)
        {
            VideoInofEventArgs videoinfo = new VideoInofEventArgs { };
            videoinfo.Title = tittle;
            videoinfo.Description = description;
            videoinfo.Duration = duration;
            return videoinfo;
        }

        public YoutubeChannel(string channelName)
        {
            ChannelName = channelName;
        }

        //public event VideoUploadEventHandler VideoUpload;
        public event EventHandler<VideoInofEventArgs> VideoUpload;

        public void UploadVideo(VideoInofEventArgs videoinfo)
        {
            Console.WriteLine($"Channel {ChannelName} has upload Video {videoinfo.Title}.");
            VideoUpload?.Invoke(this, videoinfo);
        }


    }
}
