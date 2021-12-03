using ILveILCEJsonEntityModels.Classlar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJsonBLL
{
    public class ILServis
    {
        private string JSonString = string.Empty; //field
        public ILServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient islemci =new WebClient())
            {
                byte[] data = islemci.DownloadData(@"C:\Users\103SABAH_UMUT\source\repos\ILveILCEJsonOrnek\belediyeler.json");
                JSonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<IL> IlleriGetir()
        {
            List<IL> ILListesi = new List<IL>();
            var jsonData = JsonConvert.DeserializeObject<List<ILJson>>(JSonString);

            foreach (var item in jsonData)
            {
                ILListesi.Add(
                    new IL()
                    {
                        ILAdi=item.il,
                        PlakaKodu=Convert.ToByte(item.plaka),
                        ILceleri=item.ilceleri
                    }

                    );
            }

            return ILListesi;
        }
    }
}
