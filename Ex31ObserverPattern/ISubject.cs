using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31ObserverPattern
{
    internal interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
        
    }
}
