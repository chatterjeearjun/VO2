using Microsoft.EntityFrameworkCore;
namespace vo2webapi
{
    public class vo2context : DbContext
    {
        public vo2context(DbContextOptions<vo2context> options) : base(options)
        {

        }
        public DbSet<tblMovies> tblMovies { get; set; }
        public DbSet<tblActors> tblActors { get; set; }
        public DbSet<tblMappings> tblMappings { get; set; }
    }
}
