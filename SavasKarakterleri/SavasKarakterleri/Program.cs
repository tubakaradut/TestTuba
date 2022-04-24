using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Insan warnior = factory.FactoryMethodInsan(Karkater.Warrior);
            warnior.Name = "tuba";
            //warnior.Damage = 5;
            warnior.Attack(15);
            Console.ReadLine();

            FactoryD factory1 = new FactoryD();

            Dwarf warnior1 = factory1.FactoryMethodD(Karkater.Warrior);
            warnior1.Defense(7);

           
        }
    }
}
