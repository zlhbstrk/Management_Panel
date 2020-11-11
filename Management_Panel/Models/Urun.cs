using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_Panel.Models
{
    public class Urun
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public bool isStock { get; set; }
        public int quantity { get; set; }
        public bool status { get; set; }
    }
}
