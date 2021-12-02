using ILveILCEJsonBLL;
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
    public partial class FormIL : Form
    {
        public FormIL()
        {
            InitializeComponent();
        }

        ILServis ilServisim = new ILServis();

        private void FormIL_Load(object sender, EventArgs e)
        {
            //Form yüklenirken burası çalışacak
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "il";
        }
    }
}
