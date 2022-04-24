using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri.Dwarf
{
  public class Factory
    {
        public Dwarf FactoryMethodDwarf(Karkater k)
        {
            Dwarf dwarf = null;

            switch (k)
            {
                case Karkater.Warrior:
                    dwarf = new Warrior();
                    break;
                case Karkater.Hunter:
                    dwarf = new Hunter();
                    break;
                case Karkater.Priest:
                    dwarf = new Priest();
                    break;
            }
            return dwarf;
        }

    }
}
