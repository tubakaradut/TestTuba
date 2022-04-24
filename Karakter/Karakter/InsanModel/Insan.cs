using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter.Aliance
{
 public interface Insan
    {
        int Id { get; set; }
        string Name { get; set; }
        int Level { get; set; }
        int Damage { get; set; }

        string Attack(int damage);
        string Defense();
    }
}
