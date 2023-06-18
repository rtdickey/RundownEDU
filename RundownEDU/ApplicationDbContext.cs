using Microsoft.EntityFrameworkCore;

namespace RundownEDU;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
	{ 
		
	}
}
