
using Microsoft.Identity.Client;

namespace dotnet7api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Character> Characters => Set<Character>();
    }
}
