using Business.Repository;
using DataAcces.Entity;
using DataAcces.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UIMenu.Common
{
    public static class Common
    {
        static BaseRepository<Siparis> siparisRepository = new BaseRepository<Siparis>();

        public static void GetirSiparis(ListBox listBox, Label label, SiparisStatus siparisStatus)
        {
            List<Siparis> siparisListe = siparisRepository.GetList(x => x.SiparisStatus == siparisStatus);
            List<string> siparisFormatListe = new List<string>();
            decimal toplamTutar = default(decimal);
            foreach (var siparis in siparisListe)
            {
                string ekstraFormat = "";
                foreach (var ekstra in siparis.SiparisEkstraListe)
                {
                    ekstraFormat += $" {ekstra.Ekstra.Ad} ";
                }
                string format = "";
                format = $"({siparis.Adet}) - {siparis.Menu.Ad} - {siparis.Boyut.Ad} - {ekstraFormat}";
                siparisFormatListe.Add(format);

                toplamTutar += siparis.ToplamTutar;
            }
            if (label != null)
            {
                label.Text = toplamTutar.ToString("C2");
            }
            if (listBox != null)
            {
                listBox.DataSource = siparisFormatListe;
            }
        }

        public static void Raporlama(ListBox listBoxMenular, ListBox listBoxEkstralar, Label labelCiro, Label labelKDVHaricGelir)
        {
            List<Ekstra> ekstraListe = new List<Ekstra>();
            List<Siparis> siparisListe = siparisRepository.GetList(x => x.SiparisStatus == SiparisStatus.tamamlandi);
            List<string> siparisFormatListe = new List<string>();
            List<string> ekstraFormatListe = new List<string>();


            decimal toplamGelir = siparisListe.Sum(x => x.ToplamTutar);

            var siparisListeGrup = siparisListe.GroupBy(x => x.Menu.Ad).ToList();
            foreach (var siparis in siparisListeGrup)
            {
                siparisFormatListe.Add($"({siparis.Count()}) Adet - {siparis.Key}");
            }

            //Ekstralar
            foreach (var siparis in siparisListe)
            {
                foreach (var ekstra in siparis.SiparisEkstraListe)
                {
                    ekstraListe.Add(ekstra.Ekstra);
                }
            }

            var ekstraListeGrup = ekstraListe.GroupBy(x => x.Ad).ToList();
            foreach (var ekstra in ekstraListeGrup)
            {
                ekstraFormatListe.Add($"({ekstra.Count()}) Adet - {ekstra.Key}");
            }

            listBoxMenular.DataSource = siparisFormatListe;
            listBoxEkstralar.DataSource = ekstraFormatListe;
            labelCiro.Text = toplamGelir.ToString("C2");
            labelKDVHaricGelir.Text = ((double)toplamGelir - ((double)toplamGelir * 0.18)).ToString("C2");
        }

    }
}
