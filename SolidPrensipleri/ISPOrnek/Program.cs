using ISPOrnek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Yunus yunus = new Yunus();
            yunus.Name = "Nani";
            Console.WriteLine(yunus.Name+" "+yunus.Yuzme());

            Kopek kopek = new Kopek();
            kopek.Name = "Çomar";
            Console.WriteLine(kopek.Name+" "+kopek.Yurume());
            Console.ReadLine();
        }
    }
}
