using Ex31ObserverPattern;

namespace Ex31ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Academy p = new Academy("UCL", "Seebladsgade");

                Student s1 = new Student(p, "Jens");
                Student s2 = new Student(p, "Niels");
                Student s3 = new Student(p, "Susan");

                p.Attach(s1);
                p.Attach(s2);
                p.Attach(s3);

                p.Message = "Så er der julefrokost!";

                p.Detach(s2);

                p.Message = "Så er der fredagsbar!";



         
        }
    }
}
//GasCompany RocketFuel = new GasCompany("Rocket Fuel", 10);

//GasStation GSAarhus = new GasStation(RocketFuel, "Jylland", "Aarhus", true);
//GasStation GSKoebenhavn = new GasStation(RocketFuel, "Sjaelland", "Koebenhavn", false);
//GasStation GSOdense = new GasStation(RocketFuel, "Fyn", "Odense", false);

//RocketFuel.Attach(GSAarhus);
//RocketFuel.Attach(GSKoebenhavn);
//RocketFuel.Attach(GSOdense);

//RocketFuel.KeroOxygenPrice = 15;
//RocketFuel.KeroOxygenPrice = 20;
//RocketFuel.Detach(GSKoebenhavn);
//RocketFuel.KeroOxygenPrice = 10;

//Console.ReadLine();

//var p = new Academy("UCL");

//var s1 = new Student(p, "Jens");
//var s2 = new Student(p, "Niels");
//var s3 = new Student(p, "Susan");

//p.Attach(s1);
//p.Attach(s2);
//p.Attach(s3);

//p.Message = "Så er der julefrokost!";

//p.Detach(s2);

//p.Message = "Så er der fredagsbar!";

//Console.ReadLine();