using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP
{
    public class KarayoluSevki : Gonderi
    {
        public  int Id { get; set; }
        public  string Ad { get; set; }
        public  double Agırlık { get; set; }
        public double MaliyetHesapla()
        {
            return Agırlık *1.5 ;
        }
    }
}
