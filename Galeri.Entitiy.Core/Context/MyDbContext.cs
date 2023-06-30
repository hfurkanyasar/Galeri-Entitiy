using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeri.Entitiy.Core.Entities;

namespace Galeri.Entitiy.Core.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(ConfigurationManager.ConnectionStrings["GaleriDB"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Arac> Aracs { get; set; }
        public DbSet<Müsteri> Müsteris { get; set; }
        public DbSet<Satis> Satis { get; set; }

       
    }
}
