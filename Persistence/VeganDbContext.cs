using System.Runtime.Intrinsics.Arm.Arm64;
using Microsoft.EntityFrameworkCore;
namespace vegan.Persistence
{
    public class VeganDbContext : DbContext
    {   
        public VeganDbContext(DbContextOptions<VeganDbContext> options)
        : base(options)
        {
            
        }
    }
}