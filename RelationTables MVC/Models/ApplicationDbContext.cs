using Microsoft.EntityFrameworkCore;

namespace RelationTables_MVC.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { 
            
        }
       public DbSet<User> Users { get; set; }
        public DbSet<Usertype> UserTypes { get; set; }  

    }
}
