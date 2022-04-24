using Karakter.Aliance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insan ınsan = new Insan();
            //Hunter hunter = new Hunter();
            //hunter.Name = "tuba";
            //ınsan.Hunter.Attack();
            //Console.WriteLine(ınsan.Hunter.Attack());
            //hunter.Attack();
            //Console.WriteLine(hunter.Attack());
            //Console.ReadLine();
            Hunter hunter = new Hunter();
            Console.WriteLine(hunter.Name+" "+ hunter.Attack(5));
            
            Console.ReadLine();

        }
    }
}
