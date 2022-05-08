using Business;
using Business.Repository;
using DataAcces.Entity;
using System;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class MenuOlustur : Form
    {
        BaseRepository<DataAcces.Entity.Menu> hamburgerMenuRepository = new BaseRepository<DataAcces.Entity.Menu>();
        public MenuOlustur()
        {
            InitializeComponent();
        }
      
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DataAcces.Entity.Menu hamburgerMenu = new DataAcces.Entity.Menu();
            hamburgerMenu.Ad = txtMenuAd.Text; ;
            hamburgerMenu.Fiyat = nudMenuFiyat.Value;
            hamburgerMenuRepository.Create(hamburgerMenu);
            //MessageBox.Show(result);

            txtMenuAd.Text = "";
            nudMenuFiyat.Value = 0;

        }
    }
}
