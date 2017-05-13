using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nypf.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "nypf.db");
            Console.WriteLine(databasePath);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        public DbSet<Artist> Artist { get; set; }

    }
}
