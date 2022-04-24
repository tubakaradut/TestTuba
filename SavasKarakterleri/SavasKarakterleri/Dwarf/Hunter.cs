using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri
{

    public class HunterD : Dwarf
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Level { get; set; }
        public override int Damage { get; set; }
        public override void Attack(int damage)
        {
            Console.WriteLine($"{Name} kılıç ile" + damage + " " + " şiddetinde atak yaptı.");
        }

        public override void Defense(int damage)
        {
            Console.WriteLine($"{Name}" + damage + " " + " siddetinde kılıç ile savunma yaptı.");
        }
    }
}
