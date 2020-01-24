using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
    public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Treat> Treats { get; set; }
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<FlavorTreat> FlavorTreatList { get; set; }
        public PierresTreatsContext(DbContextOptions options) : base(options) { }
    }
    
}