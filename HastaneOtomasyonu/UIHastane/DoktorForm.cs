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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }
        BaseRepository<Doktor> drRepository = new BaseRepository<Doktor>();
        BaseRepository<Brans> bransRepository = new BaseRepository<Brans>();
       
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor dr = new Doktor();
            dr.DoktorAd = txtDAd.Text;
            dr.DoktorSoyad = txtDSoyad.Text;
            dr.DoktorTc = txtDTc.Text;
            dr.DoktorTelefon = txtDTelefon.Text;
            dr.BransId = (int)CmbBrans.SelectedValue;
            drRepository.Create(dr);
           
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            CmbBrans.DisplayMember = "BransAd";
            CmbBrans.ValueMember = "Id";
            CmbBrans.DataSource = bransRepository.GetList();
            
        }
    }
}
