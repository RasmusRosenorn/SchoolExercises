using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31ObserverPattern
{
    internal class Student : Person, IObserver
    {
        private Academy academy;
        public string Message { get; set; }

        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
        }
        public void Update()
        {
            Message = $"Studerende {Name} modtog beskeden \"{academy.Message}\" fra {academy.Name} nååååårh ja";
            Console.WriteLine(Message); 
        }
    }
}
