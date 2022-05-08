using System;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
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
    
        private void siparişToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            childForm(new SiparisOlustur());
        }

        private void menuOluşturToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            childForm(new MenuOlustur());
        }

        private void ekstraOluşturToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            childForm(new EkstraOlustur());
        }

        private void siparişlerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            childForm(new Siparisler());
        }

        private void krediKartıTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new KrediKartiTanimla());
        }

        private void boyutOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new BoyutOlustur());
        }

    }
}
