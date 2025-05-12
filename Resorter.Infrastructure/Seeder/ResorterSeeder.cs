using Resorter.Domain.Entities;
using Resorter.Infrastructure.Persistence;

namespace Resorter.Infrastructure.Seeder;

public class ResorterSeeder : IResorterSeeder
{
    private readonly ResorterDbContext _context;

    public ResorterSeeder(ResorterDbContext context)
    {
        _context = context;
    }

    public async Task Seed()
    {
        if (!_context.Properties.Any())
        {
            var properties = new List<Property>
            {
                new Property
                {
                    Title = "Ocean View Villa",
                    Price = 500000,
                    Description = "Luxury villa with a stunning ocean view.",
                    Location = "Malibu, CA",
                    Sqft = 3500,
                    Status = "Available"
                },
                new Property
                {
                    Title = "Mountain Cabin Retreat",
                    Price = 250000,
                    Description = "Cozy cabin in the mountains, perfect for a getaway.",
                    Location = "Aspen, CO",
                    Sqft = 1800,
                    Status = "Available"
                },
                new Property
                {
                    Title = "Urban Apartment",
                    Price = 300000,
                    Description = "Modern apartment in the heart of the city.",
                    Location = "New York, NY",
                    Sqft = 900,
                    Status = "Sold"
                }
            };

            _context.Properties.AddRange(properties);
            await _context.SaveChangesAsync();
        }
    }
}
