using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP
{
    public interface Gonderi
    {
        int Id { get; set; }
        string Ad { get; set; }
        double Agırlık { get; set; }

        double MaliyetHesapla();


        //yazılımı oluşturan her bir parçanın geliştirmelere açık, değişime kapalı olmasını gerektiğinden bu ana classa dokunmadan istediğimiz kadar alt class olusturup bu classtan yetenek verilerek gelişterebiliriz.

        //Bu classta olusturulan metod maliyet hesapla görevi yapmakla yükümlü ancak her sevk yolunun da kendine özgü  fiyat hesaplama yöntemi oldugundan bu classı interface yapıp diger claslara yetenek vererek diger sevk yollarının kendi içlerinde kendilerine ozgu  fiyat hesaplaması yapmasına olanak tanınır.

        //yeni bir sevk yolu eklendiginde buradan yetenek alınır.Yani bu sayede istenildiği kadar sevk yolu eklendiğinde herhangi bir değişikik olmaz.

    }
}
