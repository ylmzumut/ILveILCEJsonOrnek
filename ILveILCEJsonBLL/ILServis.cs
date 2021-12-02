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
            return JsonConvert.DeserializeObject<List<IL>>(JSonString);
        }
    }
}
