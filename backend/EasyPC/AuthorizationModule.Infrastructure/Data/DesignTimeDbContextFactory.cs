using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AuthorizationModule.Infrastructure.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AuthorizationDbContext>
{
    public AuthorizationDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "EasyPC");

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", false)
            .AddJsonFile("appsettings.Development.json", true)
            .Build();

        var connectionString = configuration.GetConnectionString("LocalDb" ) ?? throw new InvalidOperationException("Connection string 'LocalDb' not found.");
        var optionsBuilder = new DbContextOptionsBuilder<AuthorizationDbContext>();
        optionsBuilder.UseNpgsql(connectionString);
        
        Console.WriteLine($"Base Path: {basePath}");
        Console.WriteLine($"Connection String: {connectionString}");
        
        return new AuthorizationDbContext(optionsBuilder.Options);
    }
}