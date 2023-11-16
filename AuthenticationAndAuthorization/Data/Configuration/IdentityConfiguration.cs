using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthenticationAndAuthorization.Data.Configuration
{
    public class IdentityConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasIndex(x => x.Email).IsUnique();
            //builder.Property(x => x.UserName).IsRequired();
        }

        public static void ApplyIdentityConfigurations(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>(opt => 
            { 
                opt.ToTable("Users"); 
                opt.HasKey(x => x.Id); 
            });
            builder.Entity<IdentityRole>(opt => 
            { 
                opt.ToTable("Roles"); 
                opt.HasKey(x => x.Id); 
            });
            builder.Entity<IdentityUserClaim<string>>(opt => 
            { 
                opt.ToTable("UserClaims"); 
                opt.HasKey(x => x.Id); 
            });
            builder.Entity<IdentityRoleClaim<string>>(opt => 
            { 
                opt.ToTable("RoleClaims"); 
                opt.HasKey(x => x.Id); 
            });
            builder.Entity<IdentityUserLogin<string>>(opt => 
            { 
                opt.ToTable("UserLogins"); 
                opt.HasKey(x => x.ProviderKey);
            });
            builder.Entity<IdentityUserToken<string>>(opt => 
            { 
                opt.ToTable("UserTokens"); 
                opt.HasKey(x => x.UserId); 
            });
            builder.Entity<IdentityUserRole<string>>(opt =>
            {
                opt.ToTable("UserRoles");
                opt.HasKey(x => x.UserId);
            });
        }
    }
}
