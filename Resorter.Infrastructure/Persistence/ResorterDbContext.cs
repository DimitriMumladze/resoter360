using Microsoft.EntityFrameworkCore;
using Resorter.Domain.Entities;

namespace Resorter.Infrastructure.Persistence;

internal class ResorterDbContext : DbContext
{
    internal ResorterDbContext(DbContextOptions<ResorterDbContext> options)
        : base(options)
    {
    }

    internal DbSet<Property> Properties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Property>().ToTable("Properties");
    }
}
