using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMarketWEB.Models
{
    public class GraficsCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GraphicsCore { get; set; }
        public string Cores { get; set; }
        public string Herts { get; set; }
        public string VRAM { get; set; }
        public string Voltage { get; set; }
    }
}
