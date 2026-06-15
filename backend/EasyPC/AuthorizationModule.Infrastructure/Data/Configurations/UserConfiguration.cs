using AuthorizationModule.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthorizationModule.Infrastructure.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(u => u.Id);
        
        builder.HasIndex(u => u.Username).IsUnique();
        
        builder.Property(u => u.Username)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(u => u.PasswordHash)
            .IsRequired();
        
        builder.Property(u => u.PasswordSalt)
            .IsRequired();
        
        builder.Property(u => u.Role)
            .IsRequired();
        
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.PhoneNumber)
            .IsRequired()
            .HasMaxLength(12);
        builder.Property(x => x.DateOfBirth)
            .IsRequired();
        builder.Property(x => x.Gender)
            .IsRequired();
    }
}