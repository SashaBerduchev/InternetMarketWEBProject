using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetMarketWEB.Models
{
    public class ZakazPokupatelya
    {
        public int Id { get; set; }
        public string Organization { get; set; }
        public string Contragent { get; set; }
        public string Sklad { get; set; }
        public string Ysluga { get; set; }
        public string Data { get; set; }
    }
}
