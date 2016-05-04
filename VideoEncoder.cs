using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePlayground
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    class VideoEncoder
    {
        // 1 - define a delegate
        // 2 - define an event based on that delegate
        // 3 - raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            System.Threading.Thread.Sleep(500);

            OnVideoEncoded(video);
            
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                var videoEventArgs = new VideoEventArgs() { Video = video };
                VideoEncoded(this,  videoEventArgs);
            }
        }
    }
}
