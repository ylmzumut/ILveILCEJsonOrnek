using ILveILCEJsonEntityModels.Classlar;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJsonBLL
{
    public class ILveILCEServis
    {
        private string JsonString = string.Empty;
        ILServis ilServisi = new ILServis();
        public ILveILCEServis()
        {
            VerikaynaginaBaglan();
        }
        private void VerikaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_UMUT\source\repos\ILveILCEJsonOrnek\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);

            }
        }

        public List<ILveILCEBilgileri> BilgilerGetir()
        {
            List<ILveILCEBilgileri> liste = new List<ILveILCEBilgileri>();

            JObject j = JObject.Parse(JsonString);

            List<string> illerim = ilServisi.IlleriGetir().Select(x => x.ILAdi).ToList();

            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();
            foreach (string item in illerim)
            {
                //her bir il için bilgileri belediyelerfull.json'dan çekicez.
                var data = j.SelectToken(item).SelectToken("il");
                ILveILCEBilgileri detayliBilgi = new ILveILCEBilgileri();
                detayliBilgi.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());
                detayliBilgi.Tel = data["belediye-tel"].ToObject<string>();
                detayliBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detayliBilgi.Ismi = data["belediye-ismi"].ToObject<string>();
                detayliBilgi.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();

                detayliBilgi.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();

                detayliBilgi.Nufus = data["nufus"].ToObject<string>();

                detayliBilgi.Alankodu = data["alankodu"] == null ? "" : data["alankodu"].ToObject<string>();

                detayliBilgi.Bolge = data["bolge"].ToObject<string>();
                detayliBilgi.Bilgi = data["bilgi"].ToString();
                liste.Add(detayliBilgi);
            }


            return liste;
        }

        public List<ILveILCEBilgileri> ILAdinaGoreILCEleriGetir(string ilAdi)
        {
            List<ILveILCEBilgileri> liste = new List<ILveILCEBilgileri>();

            JObject j = JObject.Parse(JsonString);

            List<string> ilcelerListem = ilServisi.IlleriGetir().Single(x => x.ILAdi == ilAdi).ILceleri;

            //ağrı --> agri // ismi json içindeki gibi değiştirdik
            ilAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ilAdi.ToLower());

            //ilçeler de json içinde ingilizce karakterli halde yazıyor.
            //bu nedenle onu da çevirdik.
            ilcelerListem = ilcelerListem.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (var item in ilcelerListem)
            {
                var data = j.SelectToken(ilAdi.ToLower()).SelectToken(item);
                //bazı illerin ilçeleri null gelmesin diye
                if (data != null)
                {
                    ILveILCEBilgileri bilgim = new ILveILCEBilgileri();
                    bilgim.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgim.Tel = data["belediye-tel"] == null ? "" : data["belediye-tel"].ToObject<string>();
                    bilgim.Faks = data["belediye-faks"] == null ? "" : data["belediye-faks"].ToObject<string>();
                    bilgim.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgim.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgim.Nufus = data["nufus"] == null ? "" : data["nufus"].ToObject<string>();
                    bilgim.Bilgi = data["bilgi"] == null ? "" : data["bilgi"].ToObject<string>();
                    liste.Add(bilgim);
                }
            }

            return liste;
        }




    }
}
