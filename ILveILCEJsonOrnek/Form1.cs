using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILveILCEJsonOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ILCESorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ILSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            FormIL fromILSorgulama = new FormIL();
            fromILSorgulama.MdiParent = this;
            fromILSorgulama.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
