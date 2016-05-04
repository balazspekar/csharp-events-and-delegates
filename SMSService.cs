using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePlayground
{
    class SMSService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("SMS Service: Sending text... " + e.Video.Title);
        }
    }
}
