using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace AnimalShelterApi.Controllers.v2
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET api/v2/Animals
    [HttpGet]
    public async Task<List<Animal>> Get(string name, string type, int minWeight, int maxWeight, string available, int pageNumber = 1, int pageSize = 1000)
    // by default, the request will not skip any pages and will list up to 1000 results
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

      if (pageNumber > 0 && pageSize > 0)
      {
        query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize); 
      }

      return await query.ToListAsync();
    }

    // GET: api/v2/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    // GET: api/v2/Animals/random
    [HttpGet("random")]
    public async Task<ActionResult<Animal>> GetRandomAnimal()
    {
      List<Animal> animals = await _db.Animals.ToListAsync();
      int random = new Random().Next(animals.Count);
      return animals[random];
    }

    // POST: api/v2/Animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }


    // PUT: api/v2/Animals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    // DELETE: api/v2/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult>DeleteReview(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }
      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}