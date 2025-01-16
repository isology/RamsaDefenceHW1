using Microsoft.EntityFrameworkCore;
using RamsaDefenceHW1.Models;

namespace RamsaDefenceHW1.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Items> Items { get; set; }

    }
}
