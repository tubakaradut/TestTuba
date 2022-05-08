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
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }
        BaseRepository<Ekstra> ekstrabaseRepository = new BaseRepository<Ekstra>();
        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            string ekstraAdi = txtEkstra.Text;
            decimal fiyat = nudEkstraFiyat.Value;

            Ekstra ekstra  = new Ekstra();
            ekstra.Ad= ekstraAdi;
            ekstra.Fiyat = fiyat;
            ekstrabaseRepository.Create(ekstra);
            //MessageBox.Show(result);

            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;
        }
    }
}
