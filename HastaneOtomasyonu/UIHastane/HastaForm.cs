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
    public partial class HastaForm : Form
    {
        public HastaForm()
        {
            InitializeComponent();
        }
        BaseRepository<Hasta> hastaRepository = new BaseRepository<Hasta>();
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.HastaAd = txtHAd.Text;
            hasta.HastaSoyad = txtHSoyad.Text;
            hasta.HastaTc = txtHTc.Text;
            hasta.HastaTelefon = txtHTc.Text;
            hasta.HastaAdres = txtHAdres.Text;
            hastaRepository.Create(hasta);
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
