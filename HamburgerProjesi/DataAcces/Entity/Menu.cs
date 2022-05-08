using System.Collections.Generic;

namespace DataAcces.Entity
{
    public class Menu : BaseClass
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public virtual List<Siparis> SiparisListe { get; set; }
        public override string ToString()
        {
            return Ad + " " + Fiyat;
        }
    }
}
