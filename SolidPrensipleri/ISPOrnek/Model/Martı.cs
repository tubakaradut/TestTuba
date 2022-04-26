using ISPOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPOrnek.Model
{
    public class Martı : Hayvan, IUcma, IYurume
    {
        public string Ucma()
        {
            return $"Martı Ucuyor";
        }

        public string Yurume()
        {
            return $"Martı yürüyor";
        }
    }
}
