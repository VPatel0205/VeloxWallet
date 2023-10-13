using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VeloxWallet.Models
{
    public class WalletTypeViewModel
    {
        public List<Wallet> Wallets { get; set; }
        public SelectList Type { get; set; }
        public string WalletType { get; set; }
        public string SearchString { get; set; }
    }
}
