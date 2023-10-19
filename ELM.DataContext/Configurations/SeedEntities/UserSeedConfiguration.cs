using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELM.DataContext.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = 1,
                     Email = "admin@yopmail.com",
                     NormalizedEmail = "ADMIN@YOPMAIL.COM",
                     NormalizedUserName = "ADMIN@YOPMAIL.COM",
                     UserName = "admin@yopmail.com",
                     Firstname = "Arman",
                     Lastname = "Mehar",
                     PasswordHash = hasher.HashPassword(null, "Arman@@12"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = 2,
                     Email = "ahmad@yopmail.com",
                     NormalizedEmail = "AHMAD@YOPMAIL.COM",
                     NormalizedUserName = "AHMAD@YOPMAIL.COM",
                     UserName = "ahmad@yopmail.com",
                     Firstname = "Ahmad",
                     Lastname = "Ali",
                     PasswordHash = hasher.HashPassword(null, "Arman@@12"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}