using Business.Repository;
using DataAcces.Entity;
using System;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class KrediKartiTanimla : Form
    {
        public KrediKartiTanimla()
        {
            InitializeComponent();
        }
        BaseRepository<KrediKarti> krediKartiTanimlaRepository = new BaseRepository<KrediKarti>();

        private void btnTanimla_Click(object sender, EventArgs e)
        {
            string krediKartiTanimAdi = txtKrediKartiTanimAdi.Text;
            string adSoyad = txtAd.Text;
            string krediKartiNumarasi = txtKrediKartNumara.Text;
            DateTime sonKullanmaTarihi = dateTimeSonKullanma.Value;
            string cvc = txtCVC.Text;
            decimal bakiye = numBakiye.Value;


            KrediKarti krediKartiTanimla = new KrediKarti();
            krediKartiTanimla.KrediKartiTanimAdi = krediKartiTanimAdi;
            krediKartiTanimla.AdSoyad = adSoyad;
            krediKartiTanimla.KrediKartiNumarasi = krediKartiNumarasi;
            krediKartiTanimla.SonKullanmaTarihi = sonKullanmaTarihi;
            krediKartiTanimla.CVC = cvc;
            krediKartiTanimla.Bakiye = bakiye;

            krediKartiTanimlaRepository.Create(krediKartiTanimla);

            txtKrediKartiTanimAdi.Text = "";
            txtAd.Text = "";
            txtKrediKartNumara.Text = "";
            dateTimeSonKullanma.Value = DateTime.Now;
            txtCVC.Text = "";
            numBakiye.Value = 0;
        }
    }
}
