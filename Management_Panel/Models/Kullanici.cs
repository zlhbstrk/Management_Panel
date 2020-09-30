using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_Panel.Models
{
    public class Kullanici
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string address { get; set; }
    }
}
