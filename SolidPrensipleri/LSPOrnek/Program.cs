using LSPOrnek.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //KesifUcak kesifUcak = new KesifUcak();
            //Console.WriteLine(kesifUcak.KesifYap());

            BaseUcak baseUcak = new KesifUcak();
            Console.WriteLine(baseUcak.KesifYap());


            
            SavasUcak savasUcak = new SavasUcak();

            Console.WriteLine(savasUcak.HedefVur());

            Console.ReadLine();

        }
    }
}
