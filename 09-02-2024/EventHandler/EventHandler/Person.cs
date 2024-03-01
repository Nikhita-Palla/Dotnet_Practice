using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_EG
{
    internal class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void Wakeup(object sender,EventArgs e)
        {
            Console.WriteLine($"{name} woke up and turns off the alarm");
        }
    }
}
