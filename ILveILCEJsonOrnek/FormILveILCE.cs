using ILveILCEJsonBLL;
using ILveILCEJsonEntityModels.Classlar;
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
    public partial class FormILveILCE : Form
    {
        public FormILveILCE()
        {
            InitializeComponent();
        }
        ILServis ilServisim = new ILServis();
        ILveILCEServis ilceServisim = new ILveILCEServis();
        private void FormILveILCE_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilServisim.IlleriGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";
        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yani içindeki değer değiştiğinde bu metot tetiklenecek/çalışacak
            IL secilenIL = comboBoxILLER.SelectedItem as IL;
            //IL secilenIL =(IL)comboBoxILLER.SelectedItem;

            //BLL'in bilgileri getirmesine ihtiyacım var.
            //BLL'de öyle bir metot olmalı ki... il ismini parametre olarak verince bana ilçeye air detay bilgileri versin.
            List<ILveILCEBilgileri> sehreAitILCElerListem= ilceServisim.ILAdinaGoreILCEleriGetir(secilenIL.ILAdi);
            listView1.Items.Clear();

            foreach (var item in sehreAitILCElerListem)
            {
                //her birini listviewitem olarak tutup

                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);

                //listView içine ekleyeceğim
                listView1.Items.Add(li);
            }

        }

        
    }
}
