using ISPOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPOrnek.Model
{
    public class Kopek : Hayvan, IYurume
    {
        public string Yurume()
        {
            return $"Köpek Yürüyor";
        }
    }
}
