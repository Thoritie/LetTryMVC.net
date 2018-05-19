using Microsoft.EntityFrameworkCore;

namespace ThorCaseStudy.Models 
{
	public class ThorCaseStudyContext : DbContext
    {
		public ThorCaseStudyContext(DbContextOptions<ThorCaseStudyContext> options)
            : base(options)
        {
        }
		public DbSet<ThorCaseStudy.Models.Thor> Thor { get; set; }
    }
}
