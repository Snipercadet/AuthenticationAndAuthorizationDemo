using AuthenticationAndAuthorization.Data.Configuration;
using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {
            
        }

        public DbSet<User> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityConfiguration.ApplyIdentityConfigurations(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(IdentityConfiguration).Assembly);

        }
    }
}
