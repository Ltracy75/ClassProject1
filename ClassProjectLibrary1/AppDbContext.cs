using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
    {
    public class AppDbContext : DbContext
        {

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<Resources> Resources { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connStr = @"server=localhost\sqlexpress;"
            + "database=ClassProj;"
            + "trustServerCertificate=true;"
            + "trusted_connection=true;";
            builder.UseSqlServer(connStr);
        }

    }
    }
