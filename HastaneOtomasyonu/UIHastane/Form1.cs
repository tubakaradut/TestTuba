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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        HastaneOtomasyonuEntities db = new HastaneOtomasyonuEntities();
      
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void randevuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RandevuForm());
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bransEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new BransForm());
        }

        private void doktorEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new DoktorForm());
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new HastaForm());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sorgularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Sorgular());
        }
    }
}
