using LSPOrnek.Entity;
using LSPOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPOrnek
{
    public class SavasUcak : BaseUcak, IHedefVur,IKesifYap
    {
        public string HedefVur()
        {
            return $"Hedef vuruluyor";
        }
     
    }
}
