using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOrnek
{
    public class Pizza
    {
        public Pizza()
        {
            MalzemeListesi = new List<string>();
        }
        public string Ad { get; set; }

        public string Boyut { get; set; }

        public double Fiyat { get; set; }

        public static List<string> MalzemeListesi { get; set; }

        //Pizza nesnesinin belirli ozelliklerini tutuyor.Tek görevi pizzanın özelliklerini tutmaktır.
    }
}
