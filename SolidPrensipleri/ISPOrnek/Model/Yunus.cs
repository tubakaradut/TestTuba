using ISPOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPOrnek.Model
{
    public class Yunus : Hayvan, IYuzme
    {
        public string Yuzme()
        {
            return $"Yunus balıgı yüzüyor";
        }
    }
}
