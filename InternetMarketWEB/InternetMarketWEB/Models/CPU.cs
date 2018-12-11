using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMarketWEB.Models
{
    public class CPU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Architecture { get; set; }
        public string Cores { get; set; }
        public string Chastota { get; set; }
        public string KESHL1 { get; set; }
        public string KESHL2 { get; set; }
        public string KESHL3 { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string TDP { get; set; }
    }
}
