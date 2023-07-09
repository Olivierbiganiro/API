
using Evet_management.Data;
using Evet_management.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Evet_management.Controllers
{
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class Eventcontroller:Controller
    {
        private readonly DataContext _context;

        public Eventcontroller(DataContext context)
    {
        _context = context;
    }
    
      [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var events = await _context.Events.ToListAsync();
            return Ok(events);
        }

       [HttpDelete("{id}")]
       public async Task<ActionResult> DeleteEvent(int id)
      {
       var @event = await _context.Events.FindAsync(id);
      if (@event == null)
      {
        return NotFound(); // Return a 404 Not Found response if the event doesn't exist
       }

       _context.Events.Remove(@event);
       await _context.SaveChangesAsync();
   
       return NoContent(); // Return a 204 No Content response if the event is successfully deleted
     }
        
        [HttpPost]
        public async Task<ActionResult<Event>> CreateEvent(Event newEvent)
        {
        if (newEvent == null)
        {
        return BadRequest("Event data is missing.");
        }

        _context.Events.Add(newEvent);
        await _context.SaveChangesAsync();
        var response = new
        {
        Message = "Event created successfully.",
        Event = newEvent
        };

        return CreatedAtAction(nameof(GetEvents), new { id = newEvent.Id }, response);
       }

       [HttpPatch("{id}")]
      public async Task<IActionResult> UpdateEvent(int id, Event updatedEvent)
    {
    var existingEvent = await _context.Events.FindAsync(id);
    if (existingEvent == null)
    {
        return NotFound(); // Return a 404 Not Found response if the event doesn't exist
    }

    existingEvent.Event_Name = updatedEvent.Event_Name;
    existingEvent.Event_Topic = updatedEvent.Event_Topic;
    existingEvent.Start_Time = updatedEvent.Start_Time;
    existingEvent.End_Time = updatedEvent.End_Time;
    existingEvent.Payment = updatedEvent.Payment;

    await _context.SaveChangesAsync();

    return NoContent(); // Return a 204 No Content response to indicate successful update
    }

    }
}