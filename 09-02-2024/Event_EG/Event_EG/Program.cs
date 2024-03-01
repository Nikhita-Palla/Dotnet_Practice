using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_EG
{
    public delegate void OnVideoUploaded();
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("Test");
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();

            video.onVideoUploaded += emailService.SendEmail;
            video.onVideoUploaded += smsService.SendSMS;

            video.UploadVideo();


        }
    }
}
