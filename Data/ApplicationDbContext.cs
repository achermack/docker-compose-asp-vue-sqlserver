using Microsoft.EntityFrameworkCore;

namespace webapi_boilerplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Course> Courses { get; set; }
    }
}