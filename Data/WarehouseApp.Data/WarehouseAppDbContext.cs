using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WarehouseApp.Data
{
    public class WarehouseAppDbContext : IdentityDbContext<IdentityUser>
    {
        public WarehouseAppDbContext(DbContextOptions<WarehouseAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cupboard> Cupboards { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
