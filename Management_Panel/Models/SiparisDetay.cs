using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_Panel.Models
{
    public class SiparisDetay
    {
        public Siparis siparis { get; set; }
        public List<Urun> urunler { get; set; }
    }
}
