using System;
using Microsoft.EntityFrameworkCore;

namespace Itbeard.Data.Design
{
    public class ApplicationDbContextSqlLight : ApplicationDbContext
    {
        public ApplicationDbContextSqlLight(DbContextOptions<ApplicationDbContextSqlLight> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite();
        }
    }
}