using Microsoft.EntityFrameworkCore;
using Resorter.Domain.Entities;

namespace Resorter.Infrastructure.Persistence;

public class ResorterDbContext : DbContext
{
    public ResorterDbContext(DbContextOptions<ResorterDbContext> options)
        : base(options)
    {
    }

    public DbSet<Property> Properties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
