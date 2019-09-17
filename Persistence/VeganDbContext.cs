using Microsoft.EntityFrameworkCore;
using vegan.Models;
namespace vegan.Persistence
{
    public class VeganDbContext : DbContext
    {   
        public VeganDbContext(DbContextOptions<VeganDbContext> options)
        : base(options)
        {
            
        }
        //dont need to explicitely add the model here as "Make"
        //uses Model references
        public DbSet<Make> Makes { get; set; }
    }
}