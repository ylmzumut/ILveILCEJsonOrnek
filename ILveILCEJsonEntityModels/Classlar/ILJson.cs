﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJsonEntityModels.Classlar
{
    public class ILJson
    {
        //Json dosyasındaki key değerleriyle aynı oluşturuldu
        public string il { get; set; }
        public string plaka { get; set; }
        public List<string> ilceleri { get; set; }
    }
}
