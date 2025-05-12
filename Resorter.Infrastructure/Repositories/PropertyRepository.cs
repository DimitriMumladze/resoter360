using Microsoft.EntityFrameworkCore;
using Resorter.Application.Interfaces;
using Resorter.Domain.Entities;
using Resorter.Infrastructure.Persistence;

namespace Resorter.Infrastructure.Repositories;

public class PropertyRepository(ResorterDbContext dbContext) : IPropertyRepository
{
    public async Task<IEnumerable<Property>> GetAllAsync()
    {
       return await dbContext.Properties.ToListAsync();
    }
}
