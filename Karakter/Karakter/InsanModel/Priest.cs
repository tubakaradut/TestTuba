using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter.Aliance
{
   public class Priest : Insan, IOzellik
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }

        public string Attack(int damage)
        {
            return $"Büyücü asa ile {damage} şiddetinde büyü yaptı.";
        }

        public string Defense()
        {
            return $"Büyücü savunma yaptı.";
        }
    }
}
