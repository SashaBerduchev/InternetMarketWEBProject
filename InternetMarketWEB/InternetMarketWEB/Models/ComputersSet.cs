using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMarketWEB.Models
{
    public class ComputersSet
    {
        public int Id { get; set; }
        public string Firm { get; set; }
        public string Model { get; set; }
        public string Quantity { get; set; }
        public string Cost { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string VRAM { get; set; }
        public string Graphics { get; set; }
    }
}
