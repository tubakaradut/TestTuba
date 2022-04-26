using Car.Abstract;
using Car.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            CarOlustur car = new AudiConcrete();
            CarKullan kullan = new CarKullan();
            kullan.ArabaKullan(car);

            CarOlustur car1 = new  BmwConcrete();
            kullan.ArabaKullan(car1);

            CarOlustur car2 = new MercedesConcrete();
            kullan.ArabaKullan(car2);

            Console.WriteLine(car.Araba.ToString());
            Console.WriteLine(car1.Araba.ToString());
            Console.WriteLine(car2.Araba.ToString());

            Console.ReadLine();

        }


    }
}
