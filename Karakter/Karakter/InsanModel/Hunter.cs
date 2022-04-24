using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter.Aliance
{
    public class Hunter : Insan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }

        public string Attack(int damage)
        {
            return $"Okçu {damage} şiddetinde ok attı.";
        }

        public string Defense()
        {
            return $"Okçu savunma yaptı.";
        }
    }
}
