using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELM.DataContext.Configurations
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<long>> builder)
        {
            builder.HasData(
                new IdentityUserRole<long>
                {
                    RoleId = 1,
                    UserId = 1
                },
                new IdentityUserRole<long>
                {
                    RoleId = 2,
                    UserId = 1
                }
            );
        }
    }
}