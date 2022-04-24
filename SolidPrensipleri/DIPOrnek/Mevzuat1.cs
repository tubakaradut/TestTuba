using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOrnek
{
    public class Mevzuat1 : IMevzuat
    {
        public void Islem()
        {
            Console.WriteLine("1. Mevzuata göre işlem yapıldı");
            Console.ReadLine();
        }
    }
}
