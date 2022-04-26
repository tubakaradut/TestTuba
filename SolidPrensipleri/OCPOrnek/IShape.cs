using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPOrnek
{
 public interface IShape
    {
        double AreaCalculation();

        //Bu clasımız tüm şekil tiplerinin alan hesabını yapmakla yükümlü ancak her alanın da kendine özgü farklı hesaplama yöntemi oldugundan bu classı interface yapıp diger claslara yetenek vererek diger sekillerin kendi içlerinde kendilerine ozgu alan hesaplaması yapmasına olanak tanınır.
        //yeni bir sekil eklendiginde buradan yetenek alınır.Yani bu sayade istenildiği kadar sekil eklendiğinde herhangi bir değişikik olmaz.
    }
}
