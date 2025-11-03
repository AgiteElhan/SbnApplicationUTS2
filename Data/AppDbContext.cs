using Microsoft.EntityFrameworkCore;
using SbnApplicationUTS2.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SbnApplicationUTS2.Data
{

        public class AppDbContext : DbContext
        {
            public DbSet<Buyer> Buyers => Set<Buyer>();
            public DbSet<SBN> SBNs => Set<SBN>();

            public DbSet<Asset> Assets => Set<Asset>();

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;" +
                    "Database=vb2_sbn;" +
                    "Username=postgres;Password=agit");
            }
        }
    
}
