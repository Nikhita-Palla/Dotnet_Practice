using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSchedular
{
    public partial class Service2 : ServiceBase
    {
        public Timer Scheduletimer;
        public Service2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread startThread = new Thread(new ThreadStart(ScheduleMail));
            startThread.Start();
        }

        public void ScheduleMail()
        {
            try
            {
                DateTime scheduleTime = DateTime.Today.Add(new TimeSpan(18, 20, 0)); // Set the scheduled time for today at 18:20

                if (DateTime.Now > scheduleTime)
                {
                    scheduleTime = DateTime.Now.AddDays(1); // Schedule it for the next second if it has already passed
                }

                TimeSpan timespan = scheduleTime - DateTime.Now;
                int dueMilli = (int)timespan.TotalMilliseconds;

                Scheduletimer = new Timer(new TimerCallback(SendMail), null, dueMilli, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex);
            }
        }


        private void SendMail(object state)
        {
            try
            {
                using(MailMessage mail=new MailMessage())
                {
                    mail.From = new MailAddress("pallanikhita@gmail.com");
                    mail.To.Add("nikhita_palla@epam.com");
                    mail.Body="Hello Nikhita";
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("pallanikhita@gmail.com", "ldcyybtrpabjyqkw");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        WriteErrorLog("Mail Sent" + DateTime.Now);


                    }
                    this.ScheduleMail();
                }
            }
            catch(Exception ex)
            {
                WriteErrorLog(ex);
            }
        }
        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        protected override void OnStop()
        {
            Scheduletimer.Dispose();
        }
    }
}
