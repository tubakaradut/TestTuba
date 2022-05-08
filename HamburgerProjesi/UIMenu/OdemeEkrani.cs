using Business.Repository;
using DataAcces.Entity;
using DataAcces.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class OdemeEkrani : Form
    {
        BaseRepository<KrediKarti> krediKartiRepository = new BaseRepository<KrediKarti>();
        BaseRepository<Siparis> siparisRepository = new BaseRepository<Siparis>();
        public OdemeEkrani()
        {
            InitializeComponent();
        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            List<KrediKarti> krediKartiListe = krediKartiRepository.GetList();

            comboBox1.DisplayMember = "KrediKartiTanimAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = krediKartiListe;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SiparisOlustur siparisOlustur = new SiparisOlustur();

            KrediKarti secilenKrediKarti = (KrediKarti)comboBox1.SelectedItem;
            List<Siparis> siparisListe = siparisRepository.GetList(x => x.SiparisStatus == SiparisStatus.olusturuldu);

            decimal toplamTutar = 0;

            foreach (var siparis in siparisListe)
            {
                toplamTutar += siparis.ToplamTutar;
            }

            if (secilenKrediKarti.Bakiye >= toplamTutar)
            {

                foreach (var siparis in siparisListe)
                {
                    Siparis siparisEntity = siparis;
                    siparisEntity.SiparisStatus = SiparisStatus.tamamlandi;
                    siparisRepository.Update(siparisEntity);
                }
                secilenKrediKarti.Bakiye -= toplamTutar;
                krediKartiRepository.Update(secilenKrediKarti);


                DialogResult dialogResult = MessageBox.Show("Siparişiniz tamamlanmıştır.", "Sipariş Bilgi", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    Common.Common.GetirSiparis(siparisOlustur.listBox1, siparisOlustur.lblToplamTutar,SiparisStatus.olusturuldu);
                    siparisOlustur.EnableIptalButon();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bakiyeniz Yetersiz! Lütfen farklı bir kredi kartı seçimi yapınız...");
            }
        }
    }
}
