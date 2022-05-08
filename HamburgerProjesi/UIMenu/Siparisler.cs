using System;
using System.Windows.Forms;

namespace UIMenu
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            Common.Common.Raporlama(listBox1,listBox2,lblCiro,lblKDVHaricGelir);
        }
    }
}
