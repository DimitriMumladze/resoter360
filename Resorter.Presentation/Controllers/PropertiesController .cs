using Microsoft.AspNetCore.Mvc;
using Resorter.Application.Interfaces;
using Resorter.Domain.Entities;

namespace Resorter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PropertiesController : ControllerBase
{
    private readonly IPropertyRepository _propertyRepository;

    public PropertiesController(IPropertyRepository propertyRepository)
    {
        _propertyRepository = propertyRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Property>>> GetAll()
    {
        var properties = await _propertyRepository.GetAllAsync();
        return Ok(properties);
    }
}
