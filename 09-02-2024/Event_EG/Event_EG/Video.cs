using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event_EG
{
    internal class Video
    {
        public OnVideoUploaded onVideoUploaded;
        public string Name { get; set; }
        public Video(string name)
        {
            Name = name;
        }
        public void UploadVideo()
        {
            Console.WriteLine("Uploading Video....");
            Thread.Sleep(1000);
            Console.WriteLine("Video Uploaded!");
            onVideoUploaded();
        }
    }
}
