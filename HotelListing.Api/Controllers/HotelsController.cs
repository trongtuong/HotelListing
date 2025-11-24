using HotelListing.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController:ControllerBase
{
    private static List<Hotel> hotels = new List<Hotel>
    {
        new Hotel{Id = 1, Name = "Hotel 1", Address = "test", Rating = 3.5},
        new Hotel{Id = 2, Name = "Hotel 1", Address = "test", Rating = 3.5}
    };
    [HttpGet]
    public ActionResult<IEnumerable<Hotel>> Get()
    {
        return Ok(hotels);
    }

    [HttpGet("{id}")]
    public ActionResult<Hotel> GetById([FromRoute]int id)
    {
        var hotel = hotels.FirstOrDefault(h => h.Id == id);
        if (hotel == null)
        {
            return NotFound();
        }
        return Ok(hotel);
    }

    [HttpPost]
    public ActionResult<Hotel> Post([FromBody] Hotel newHotel)
    {
        if (hotels.Any(h => h.Id == newHotel.Id))
        {
            return BadRequest("Hotel with this Id already exists");
        }
        hotels.Add(newHotel);
        
        return CreatedAtAction(nameof(GetById), new { id = newHotel.Id }, newHotel);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Hotel updatedHotel)
    {
        var existingHotel = hotels.FirstOrDefault(h => h.Id == id);
        if (existingHotel == null)
        {
            return NotFound();
        }
        existingHotel.Name = updatedHotel.Name;
        existingHotel.Address = updatedHotel.Address;
        existingHotel.Rating = updatedHotel.Rating;
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete([FromRoute]int id)
    {
        var hotel = hotels.FirstOrDefault(h => h.Id == id);
        if (hotel == null)
        {
            return NotFound(new {message = "Hotel not found"});
        }
        
        hotels.Remove(hotel);
        return NoContent();
        
    }
    
}