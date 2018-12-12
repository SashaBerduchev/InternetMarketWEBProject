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
        public DbSet<Contragents> contragents { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<CPU> cpus { get; set; }
        public DbSet<DocForPain> docForPains { get; set; }
        public DbSet<Dogovor> dogovors { get; set; }
        public DbSet<GraficsCard> grafics { get; set; }
        public DbSet<Oblast> oblasts { get; set; }
        public DbSet<Organisation> organisations { get; set; }
        public DbSet<OrganisationProfession> organisationProfessions { get; set; }
        public DbSet<Phones> phones { get; set; }
        public DbSet<Regions> regions { get; set; }
        public DbSet<Streets> streets { get; set; }
        public DbSet<Tablets> tablets { get; set; }
        public DbSet<Tivis> tivis { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<ZakazPokupatelya> zakazPokupatelyas { get; set; }
    }
}
