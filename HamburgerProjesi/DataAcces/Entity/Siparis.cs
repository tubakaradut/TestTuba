using DataAcces.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcces.Entity
{
    public class Siparis:BaseClass
    {
        public Siparis()
        {
            SiparisEkstraListe = new List<SiparisEkstra>();
        }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public SiparisStatus SiparisStatus { get; set; }

        public int BoyutId { get; set; }
        public virtual Boyut Boyut { get; set; }

        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }

        public virtual List<SiparisEkstra> SiparisEkstraListe { get; set; }
    }
}
