using System;

namespace DataAcces.Entity
{
    public class KrediKarti : BaseClass
    {
        public string KrediKartiTanimAdi { get; set; }
        public string AdSoyad { get; set; }
        public string KrediKartiNumarasi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public decimal Bakiye { get; set; }
        public string CVC { get; set; }
    }
}
