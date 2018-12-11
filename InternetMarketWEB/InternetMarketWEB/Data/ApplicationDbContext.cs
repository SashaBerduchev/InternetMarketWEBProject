using System;
using System.Collections.Generic;
using System.Text;
using InternetMarketWEB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternetMarketWEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BankSet> banks { get; set; }
        public DbSet<CityData> cities { get; set; }
        public DbSet<CkladSet> cklads { get; set; }
        public DbSet<ComputersSet> computers { get; set; }
    }
}
