using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace AnimalShelterApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public async Task<List<Animal>> Get(string name, string type, int minWeight, int maxWeight, string available)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (minWeight > 0)
      {
        query = query.Where(entry => entry.Weight >= minWeight);
      }

      if (maxWeight > 0)
      {
        query = query.Where(entry => entry.Weight >= maxWeight);
      }

      if (available == "true")
      {
        query = query.Where(entry => entry.AvailabilityStatus == true);
      }

      if (available == "false")
      {
        query = query.Where(entry => entry.AvailabilityStatus == false);
      }

      return await query.ToListAsync();
    }
  }
}