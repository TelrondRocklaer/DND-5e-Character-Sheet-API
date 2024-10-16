using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DND5eAPI.Models;

namespace DND5eAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext (DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<DND5eAPI.Models.Armor> Armor { get; set; } = default!;
    }
}
