using Microsoft.EntityFrameworkCore;

namespace EntityFw.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Superhero> SuperHeroes { get; set; }
    }
}
