using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_Panel.Models
{
    public class Siparis
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }
        public bool status { get; set; }
    }
}
