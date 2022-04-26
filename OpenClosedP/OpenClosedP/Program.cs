using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP
{
    class Program
    {
        static void Main(string[] args)
        {
           KarayoluSevki gonderi = new KarayoluSevki();
            gonderi.Ad = "Kamyon";
            gonderi.Agırlık = 5;
            gonderi.MaliyetHesapla();
            Console.WriteLine("Karayolu Ulasım aracı "+gonderi.Ad+" ile  "+ gonderi.Agırlık+" kg agırlıgındaki gönderinin " +" maliyeti " +gonderi.MaliyetHesapla());
            Console.ReadLine();


            DenizYoluSevk gonderi1 = new DenizYoluSevk();
            gonderi1.Ad = "Batık Gemi";
            gonderi1.Agırlık =12;
            gonderi1.MaliyetHesapla();
            Console.WriteLine("Denizyolu Ulasım aracı " + gonderi1.Ad + " ile  " + gonderi1.Agırlık + " kg agırlıgındaki gönderinin " + " maliyeti " + gonderi1.MaliyetHesapla());
            Console.ReadLine();

            HavaYoluSevk gonderi3 = new HavaYoluSevk();
            gonderi3.Ad = "Teyyare";
            gonderi3.Agırlık = 8;
            gonderi3.MaliyetHesapla();
            Console.WriteLine("Havayolu Ulasım aracı " + gonderi3.Ad + " ile  " + gonderi3.Agırlık + " kg agırlıgındaki gönderinin " + " maliyeti " + gonderi3.MaliyetHesapla());
            Console.ReadLine();


        }
    }
}
