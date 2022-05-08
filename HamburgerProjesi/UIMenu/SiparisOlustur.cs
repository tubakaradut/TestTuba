using Business.Repository;
using DataAcces.Entity;
using DataAcces.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Menu = DataAcces.Entity.Menu;

namespace UIMenu
{
    public partial class SiparisOlustur : Form
    {
        BaseRepository<Menu> menuRepository = new BaseRepository<Menu>();
        BaseRepository<Boyut> boyutRepository = new BaseRepository<Boyut>();
        BaseRepository<Ekstra> ekstraRepository = new BaseRepository<Ekstra>();
        BaseRepository<Siparis> siparisRepository = new BaseRepository<Siparis>();
        BaseRepository<SiparisEkstra> siparisEkstraRepository = new BaseRepository<SiparisEkstra>();

        public SiparisOlustur()
        {
            InitializeComponent();
        }

        public void SiparisOlustur_Load(object sender, EventArgs e)
        {
           
            List<Menu> menuliste = menuRepository.GetList();
            cmbMenu.DisplayMember = "Ad" + " " + "Fiyat";
            cmbMenu.ValueMember = "Id";
            cmbMenu.DataSource = menuliste;
            cmbMenu.SelectedIndex = -1;

            List<Ekstra> ekstraliste = ekstraRepository.GetList();

            foreach (var ekstra in ekstraliste)
            {
                CheckBox chk = new CheckBox();
                chk.Text = $"{ekstra.Ad} {ekstra.Fiyat.ToString("C2")}";
                chk.Name = "check" + ekstra.Ad;
                chk.Tag = ekstra;//boxing
                pnlEkstralar.Controls.Add(chk);
            }

            List<Boyut> boyutlistesi = boyutRepository.GetList();
            foreach (var boyut in boyutlistesi)
            {
                RadioButton rb = new RadioButton();
                rb.Text = $"{boyut.Ad} {boyut.Fiyat.ToString("C2")}";
                rb.Name = "rb" + boyut.Ad;
                rb.Tag = boyut;
                rb.AutoSize = AutoSize;
                pnlBoyutlar.Controls.Add(rb);
            }
            Common.Common.GetirSiparis(listBox1, lblToplamTutar, SiparisStatus.olusturuldu);
            EnableIptalButon();
           
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int boyutId = default(int);
            decimal toplamTutar = default(decimal);

            List<int> selectedEkstras = new List<int>();
            Menu menu = (Menu)cmbMenu.SelectedItem;

            foreach (CheckBox chk in pnlEkstralar.Controls)
            {
                if (chk.Checked)
                {
                    Ekstra ekstra = (Ekstra)chk.Tag;
                    selectedEkstras.Add(ekstra.Id);
                    toplamTutar += ekstra.Fiyat;
                }
            }

            foreach (RadioButton radio in pnlBoyutlar.Controls)
            {
                if (radio.Checked)
                {
                    Boyut boyut = (Boyut)radio.Tag;
                    boyutId = boyut.Id;
                    toplamTutar += boyut.Fiyat;
                }
            }

            int menuId = menu.Id;
            int adet = (int)nudAdet.Value;

            //Toplam Fiyat
            toplamTutar += menu.Fiyat;
            toplamTutar = toplamTutar * adet;

            Siparis siparis = new Siparis();
            siparis.Adet = adet;
            siparis.ToplamTutar = toplamTutar;
            siparis.BoyutId = boyutId;
            siparis.MenuId = menuId;
            siparis.SiparisStatus = SiparisStatus.olusturuldu;


            Siparis siparisSonuc = siparisRepository.Create(siparis);

            foreach (int ekstraId in selectedEkstras)
            {
                SiparisEkstra siparisEkstra = new SiparisEkstra();
                siparisEkstra.EkstraId = ekstraId;
                siparisEkstra.SiparisId = siparisSonuc.Id;
                siparisEkstraRepository.Create(siparisEkstra);
            }
            Common.Common.GetirSiparis(listBox1, lblToplamTutar, SiparisStatus.olusturuldu);
            EnableIptalButon();
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {

            OdemeEkrani odemeEkrani = new OdemeEkrani();
            odemeEkrani.Show();
            listBox1.Items.Clear();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            List<Siparis> siparisListe = siparisRepository.GetList(x => x.SiparisStatus == SiparisStatus.olusturuldu);
            var secilen = siparisListe[listBox1.SelectedIndex];

            if (secilen != null)
            {
                DialogResult dialogResult = MessageBox.Show("Seçilen siparişi iptal etmek istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    BaseRepository<Siparis> siparisRepository = new BaseRepository<Siparis>();
                    Siparis siparisEntity = secilen;
                    siparisEntity.SiparisStatus = SiparisStatus.iptal;
                    siparisRepository.Update(siparisEntity);

                    Common.Common.GetirSiparis(listBox1, lblToplamTutar, SiparisStatus.olusturuldu);
                    EnableIptalButon();
                }
            }
        }

        public void EnableIptalButon()
        {
            if (listBox1.Items.Count > 0)
            {
                btnIptal.Enabled = true;
            }else
            {
                btnIptal.Enabled = false;
            }
        }
    }
}
