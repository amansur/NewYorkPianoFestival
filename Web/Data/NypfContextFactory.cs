using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Nypf.Data
{
	public class NypfContextFactory : IDbContextFactory<NypfContext>
	{
		public NypfContext Create(DbContextFactoryOptions options)
		{
			var optionsBuilder = new DbContextOptionsBuilder<NypfContext>();
			optionsBuilder.UseSqlite("Data Source=nypf.db");

			return new NypfContext(optionsBuilder.Options);
		}
	}
}