using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri
{
  public class FactoryD
    {
        public Dwarf FactoryMethodD(Karkater k)
        {
            Dwarf dwarf = null;

            switch (k)
            {
                case Karkater.Warrior:
                    dwarf = new WarriorD();
                    break;
                case Karkater.Hunter:
                    dwarf = new HunterD();
                    break;
                case Karkater.Priest:
                    dwarf = new PriestD();
                    break;
            }
            return dwarf;
        }

    }
}
