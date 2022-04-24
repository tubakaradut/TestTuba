using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici = new Yonetici(new Mevzuat1());
            yonetici.Ekle();

            Yonetici yonetici1 = new Yonetici(new Mevzuat2());
            yonetici1.Ekle();

        }
    }
}
