using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasKarakterleri
{
public abstract class Insan
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Level { get; set; }
        public abstract int Damage { get; set; }
        public abstract void Attack(int damage);
        public abstract void Defense(int damage);
       
    }
}
