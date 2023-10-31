using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31ObserverPattern
{
    internal class GasCompany : Subject
    {
        public string Name { get; }
        private double _keroOxygenPrice;
        public double KeroOxygenPrice
        {
            get { return _keroOxygenPrice; }
            set
            {
                _keroOxygenPrice = value;
                Notify();
            }
        }
        public GasCompany(string name, double keroOxygenPrice)
        {
            Name = name;
            KeroOxygenPrice = keroOxygenPrice;
        }
    }
}
