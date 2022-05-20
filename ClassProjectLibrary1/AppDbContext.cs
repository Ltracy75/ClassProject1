using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
    {
    internal class AppDbContext : DbContext
        {
        AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<Resources> Resources { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        }
    }
