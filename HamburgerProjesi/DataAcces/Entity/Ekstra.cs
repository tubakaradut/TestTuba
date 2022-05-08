using System.Collections.Generic;

namespace DataAcces.Entity
{
    public class Ekstra:BaseClass
    {
        public Ekstra()
        {
            SiparisEkstraListe = new List<SiparisEkstra>();
        }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public virtual List<SiparisEkstra> SiparisEkstraListe { get; set; }//sistem otomatik olarak listeyi dolu getiriyor virtual sayesinde -lazy loading- 
        public override string ToString()
        {
            return Ad + " " + Fiyat;
        }
    }
}
