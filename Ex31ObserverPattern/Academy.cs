using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31ObserverPattern
{
    internal class Academy : Organization, ISubject
    {
        private List<IObserver> students = new List<IObserver>();
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Notify();
            }
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Attach(IObserver o)
        {
            students.Add(o);
        }

        public void Detach(IObserver o)
        {
            students.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in students)
            {
                o.Update();
            }
        }
    }
}
