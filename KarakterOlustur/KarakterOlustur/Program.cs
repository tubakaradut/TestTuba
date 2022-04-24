using System;

namespace KarakterOlustur
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            HareketTurleri warrior = factory.FactoryMethod(Sinif.Insan,Karakter.Warrior);
            HareketTurleri hunter = factory.FactoryMethod(Sinif.Org,Karakter.Hunter);

            warrior.Attack();
            hunter.Attack();

            Console.ReadLine();
        }
    }
}
