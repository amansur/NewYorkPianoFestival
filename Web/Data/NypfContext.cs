using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nypf.Data
{
    public class NypfContext : DbContext
    {
        public NypfContext(DbContextOptions<NypfContext> options) :base(options)
        {
        }

        public DbSet<Artist> Artist { get; set; }

    }
}
