using Resorter.Domain.Entities;

namespace Resorter.Application.Interfaces;

public interface IPropertyRepository
{
    Task<IEnumerable<Property>> GetAllAsync();
}
