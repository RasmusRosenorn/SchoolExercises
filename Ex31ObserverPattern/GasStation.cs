using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31ObserverPattern
{
    internal class GasStation : Observer
    {
        private GasCompany subject;
        public string Region { get; set; }
        public string City { get; set; }
        private double keroOxygenPrice;
        private double hydroOxygenPrice;
        private double alcoOxygenPrice;
        private bool discount;
        public GasStation(GasCompany subject, string region, string city, bool discount)
        {
            this.subject = subject;
            Region = region;
            City = city;
            this.discount = discount;
        }
        public override void Update()
        {
            UpdatePrices();
            ChangePriceBoard();
        }
        void UpdatePrices()
        {
            if (Region == "Fyn")
                keroOxygenPrice = subject.KeroOxygenPrice * 0.95;
            else if (Region == "Sjaelland")
                keroOxygenPrice = subject.KeroOxygenPrice * 1.05;
            else
                keroOxygenPrice = subject.KeroOxygenPrice;

            if (discount)
                keroOxygenPrice = keroOxygenPrice * 0.9;

            hydroOxygenPrice = keroOxygenPrice * 1.1;
            alcoOxygenPrice = keroOxygenPrice * 0.9;                
        }
        void ChangePriceBoard()
        {
            string priceBoardsChanged = $"In {City} the gas prices are as follows. \n KeroOxygen: {keroOxygenPrice} \n HydroOxygen: {hydroOxygenPrice} \n AlcoOxygen: {alcoOxygenPrice}";   
            Console.WriteLine(priceBoardsChanged);
        }
    }
}
