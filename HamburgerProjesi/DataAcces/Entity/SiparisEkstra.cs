namespace DataAcces.Entity
{
    public class SiparisEkstra
    {
        public int SiparisId { get; set; }
        public int EkstraId { get; set; }

        public virtual Siparis Siparis { get; set; }
        public virtual Ekstra Ekstra { get; set; }
    }
}
