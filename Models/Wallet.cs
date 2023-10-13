using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloxWallet.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public string MaterialType { get; set; }
        public string Type { get; set; }
        public string Edition { get; set; }
        public string Make { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
    }
}
