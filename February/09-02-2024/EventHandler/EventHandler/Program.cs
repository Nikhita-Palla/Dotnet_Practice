using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_EG
{
    public class AlarmClock
    {
        public event EventHandler Alarm;

        public void TriggerAlarm()
        {
            Console.WriteLine("Alarm is ringing...");
            OnAlarm();
        }

        public virtual void OnAlarm()
        {
            Alarm?.Invoke(this, EventArgs.Empty);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();

            Person p1=new Person("John");
            Person p2 = new Person("Cena");

            alarmClock.Alarm += p1.Wakeup;
            alarmClock.Alarm += p2.Wakeup;

            alarmClock.TriggerAlarm();
        }
    }
}
