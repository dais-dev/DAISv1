using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DAISv1.Models;
namespace DAISv1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { 

    }
    
    public DbSet<Asset> Asset { get; set; } = default!;
    public DbSet<User> User { get; set; } = default!;

public DbSet<DAISv1.Models.AssetParameterOptions> AssetParameterOptions { get; set; } = default!;
    
}
