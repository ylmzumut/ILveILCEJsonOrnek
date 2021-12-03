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
    public partial class FormIL : Form
    {
        public FormIL()
        {
            InitializeComponent();
        }

        ILServis ilServisim = new ILServis();
        ILveILCEServis ilveILceServisim1 = new ILveILCEServis();

        private void FormIL_Load(object sender, EventArgs e)
        {
            //Form yüklenirken burası çalışacak

            //combobox'ın içine illeri getirdim.
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "ILAdi";
            comboBoxILSecimi.ValueMember = "PlakaKodu";

            //ListView içini dolduracağız

            List<ILveILCEBilgileri> SehireAitBilgilerListesi = ilveILceServisim1.BilgilerGetir();

            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text = item.Ismi,
                    Tag=item
                };
                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);
                //listView'e ekleme yapılacak.
                listView1.Items.Add(deger);
            }

            //groupbox başlangıçta gizli olmalıdır.
            groupBoxIL.Enabled = false;
            groupBoxIL.Visible = false;
            //detay göster şeklinde sağ tık menüsü gerekiyor.
            // bu kontrol toolbox'ta var istersek designer ekranında toolbox'tan çekip form üzerine yerleştirebiliriz.
            // ama biz bunu designerdan yapmaıp code ekrann
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //combox'ta hangi ili seçtiyse onunn bilgilerini listView'de görelim
            //1.yol
            IL secilenIL = comboBoxILSecimi.SelectedItem as IL;
            //kısa yol
            //IL secilenIL =(IL)comboBoxILSecimi.SelectedItem;

            //Linq ile şart yazıyorum
            //where yazdık --> verilen koşula göre bilgileri getirir.
            //FirstOrDefault --> where'den dönen liste elemanlarından sadece birini alıyoruz.

            ILveILCEBilgileri secilenILBilgisi = ilveILceServisim1.BilgilerGetir().Where(x => x.Plaka == secilenIL.PlakaKodu).FirstOrDefault();

            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();
            deger.Text = secilenILBilgisi.Ismi;
            deger.Tag = secilenILBilgisi;
            deger.SubItems.Add(secilenILBilgisi.Tel);
            deger.SubItems.Add(secilenILBilgisi.Faks);
            deger.SubItems.Add(secilenILBilgisi.Mail);
            deger.SubItems.Add(secilenILBilgisi.Web);
            listView1.Items.Add(deger);

        }


        private void detayGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxIL.Visible = true;
            groupBoxIL.Enabled = true;

            ILveILCEBilgileri secilenIL = (ILveILCEBilgileri)listView1.FocusedItem.Tag;
            richTextBoxIL.Text = secilenIL.Bilgi;
        }
    }
}
