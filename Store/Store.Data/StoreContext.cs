using Microsoft.EntityFrameworkCore;
using Store.Common.Models;

namespace Store.Data
{
    public class StoreContext:DbContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=Store";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
