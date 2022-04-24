using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri
{
   public class Factory
    {
        public Insan FactoryMethodInsan(Karkater k)
        {
            Insan ınsan = null;

            switch (k)
            {
                case Karkater.Warrior:
                    ınsan = new Warrior();
                    break;
                case Karkater.Hunter:
                    ınsan = new Hunter();
                    break;
                case Karkater.Priest:
                    ınsan = new Priest();
                    break;
            }
            return ınsan;
        }

      
    }
}
