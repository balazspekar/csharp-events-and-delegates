using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Terminator" };
            var videoEncoder = new VideoEncoder();
            var emailService = new EmailService();
            var smsService = new SMSService();

            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
