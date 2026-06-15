using AuthorizationModule.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthorizationModule.Infrastructure.Data.Configurations;

public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.ToTable("AuditLog");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Action).HasMaxLength(200).IsRequired();
        
        builder.Property(x => x.UserName).HasMaxLength(100).IsRequired();
        
        builder.Property(x => x.HttpMethod)
            .HasMaxLength(10);
        builder.Property(x => x.Endpoint).HasMaxLength(500);
        
        builder.Property(x => x.IpAddress).HasMaxLength(45);
        
        builder.Property(x => x.Description).HasMaxLength(1000);
        
        builder.HasIndex(x => x.Timestamp).IsUnique().IsDescending();
        builder.HasIndex(x => new {x.UserName, x.Timestamp});
        builder.HasIndex(x => x.Action);
    }
}