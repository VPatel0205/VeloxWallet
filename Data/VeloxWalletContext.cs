using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VeloxWallet.Models;

namespace VeloxWallet.Data
{
    public class VeloxWalletContext : IdentityDbContext
    {
        public VeloxWalletContext(DbContextOptions<VeloxWalletContext> options)
            : base(options)
        {
        }
        public DbSet<Wallet> Wallet { get; set; }
    }
}
