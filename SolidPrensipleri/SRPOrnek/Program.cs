using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            MalzemeIslemleri malzemeIslemleri = new MalzemeIslemleri();
            malzemeIslemleri.MalzemeEkle("elma");


            foreach (var malzeme in Pizza.MalzemeListesi)
            {
                Console.WriteLine(malzeme);
            }

            Console.ReadLine();
            
        }
    }
}
