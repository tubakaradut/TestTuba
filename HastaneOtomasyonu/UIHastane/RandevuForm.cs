using BLL.Repository;
using DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHastane
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }
        BaseRepository<Doktor> drRepository = new BaseRepository<Doktor>();
        BaseRepository<Brans> bransRepository = new BaseRepository<Brans>();
        BaseRepository<Hasta> hastaRepository = new BaseRepository<Hasta>();
        BaseRepository<Randevu> randevuRepository = new BaseRepository<Randevu>();

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            cmbBrans.DisplayMember = "BransAd";
            cmbBrans.ValueMember = "Id";
            cmbBrans.DataSource = bransRepository.GetList();

            cmbHasta.DisplayMember = "HastaAd" + " " + "HastaSoyad";
            cmbHasta.ValueMember = "Id";
            cmbHasta.DataSource = hastaRepository.GetList();

            dateTimePicker1.MinDate = DateTime.Today; //Form acıldıgında tarih ayarı bugune ceker ancak valuechanged aktif olmaması için eventi manuel olarak atıyoruz.
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);// 

            cmbBrans.Text = "";
            cmbHasta.Text = "";
            cmbDoktor.Text = "";
            txtSikayet.Text = "";
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Text = "";
            Brans secilibrans = (Brans)cmbBrans.SelectedItem;
            List<Doktor> doktorslistesi = drRepository.GetList(x => x.BransId == secilibrans.Id);
            cmbDoktor.DisplayMember = "DoktorAd" +" "+ "DoktorSoyad";
            cmbDoktor.ValueMember = "Id";
            cmbDoktor.DataSource = doktorslistesi.ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Randevu saati seciniz");
            double sayi = 0;
            for (int i = 9; i < 16; i++)
            {
                for (int j = 9; j < 13; j++)
                {
                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 23;
                    btn.Top = 23 * j;
                    btn.Left = 90 * i;
                    btn.Text = string.Format($"{i}  : {sayi.ToString("00")}");
                    btn.Name = btn.Text;
                    flowLayoutPanel1.Controls.Add(btn);
                    sayi = sayi + 15;
                    btn.Click += Btn_Click;
                }
                sayi = 0;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            randevu.RandevuSaat = btn.Text;
            btn.BackColor = Color.Red;

        }
        Randevu randevu = new Randevu();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            randevu.RandevuTarih = dateTimePicker1.Value;
            randevu.BransId = (int)cmbBrans.SelectedValue;
            randevu.DoktorId = (int)cmbDoktor.SelectedValue;
            randevu.HastaId = (int)cmbHasta.SelectedValue;
            randevu.HastaSikayet = txtSikayet.Text;
            randevuRepository.Create(randevu);
        }
    }

}
