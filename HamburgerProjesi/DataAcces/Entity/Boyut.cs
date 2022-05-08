using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcces.Entity
{
    [Table("Boyuts")] //SQL deeki tablonun adı bu olsun istediğimizde
    public class Boyut:BaseClass
    {
        [Required] // zorunlu alan yapar bos geçilemez
        [Column("Ad")] // attribute SQLde colon adı böyle olsun isteğimizde
        [DataType(DataType.Text)] //Kolonun tipini belirtir.

        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public virtual List<Siparis> SiparisListe { get; set; } //sipariş clasından boyut bilgisine ulaşabilmek için virtual liste tanımlanır.virtual tanımlanmazsa deger null geliyor.

        public override string ToString()
        {
            return Ad + " " + Fiyat;
        }
    }
}
