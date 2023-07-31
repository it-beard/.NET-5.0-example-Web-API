using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Itbeard.Data.Design
{
    public class ApplicationDbDesignTimeContextFactory : IDesignTimeDbContextFactory<ApplicationDbContextSqlLight>
    {
        public ApplicationDbContextSqlLight CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContextSqlLight>();

            if (args.Any())
            {
                string connectionString = args[0];
                optionsBuilder.UseSqlite(connectionString);
            }

            return new ApplicationDbContextSqlLight(optionsBuilder.Options);
        }
    }
}