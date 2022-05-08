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
    public partial class BransForm : Form
    {
        public BransForm()
        {
            InitializeComponent();
        }
        BaseRepository<Brans> bransRepository = new BaseRepository<Brans>();
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransAd = txtBAd.Text;
            bransRepository.Create(brans);
        }
    }
}
