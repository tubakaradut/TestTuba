using Business.Repository;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class BoyutOlustur : Form
    {
        public BoyutOlustur()
        {
            InitializeComponent();
        }
        BaseRepository<Boyut> boyutrepository = new BaseRepository<Boyut>();
        private void btnBoyutEkle_Click(object sender, EventArgs e)
        {
            Boyut boyut = new Boyut();
            boyut.Ad = txtBoyut.Text;
            boyut.Fiyat = nudBoyutFiyat.Value;

            boyutrepository.Create(boyut);
            txtBoyut.Text="";
            nudBoyutFiyat.Value = 0;
        }
    }
}
