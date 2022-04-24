using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter.Aliance
{
 public   class Warrior1 : Insan
    {
        public int Id { get; set ;  }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }

        public string Attack(int damage)
        {
            return $"Savaşçı kılıç ile {damage} şiddetinde atak yaptı.";
        }

        public string Defense()
        {
            return $"Savaşçı savunma yaptı.";
        }
    }
}
