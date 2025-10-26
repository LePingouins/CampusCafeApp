using CampusCafeApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CampusCafeApp.Data
{
    public class CafeContext : DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; } = default!;
    }
}
