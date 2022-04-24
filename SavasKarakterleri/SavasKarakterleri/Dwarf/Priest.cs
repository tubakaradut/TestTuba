using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri.Dwarf
{
 public  class Priest : Dwarf
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Level { get; set; }
        public override int Damage { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"{Name}  {Damage} şiddetinde büyü yaptı.");
        }

        public override void Defense()
        {
            Console.WriteLine($"{Name} büyü ile savunma yaptı.");
        }
    }
}
