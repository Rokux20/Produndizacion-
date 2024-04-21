using Clase.Models;
using Clase.Services;
using Clase.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsService _eventsService;
        public EventsController(IEventsService eventsService)
        {
            _eventsService = eventsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Events>>> GetAll()
        {
            return Ok(await _eventsService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Events>> GetById(int id)
        {
            var events = await _eventsService.GetById(id);
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
        }
        [HttpPost]
        public async Task<ActionResult<Events>> CreateEvent([FromBody] Events events)
        {
            return Ok(await _eventsService.CreateEvent(events.Name, events.Description, events.Date, events.MaxCapacity));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Events>> UpdateEvent(int id, [FromBody] Events events)
        {
            try
            {
                return Ok(await _eventsService.UpdateEvent(id, events.Name, events.Description, events.Date, events.MaxCapacity));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Events>> DeleteEvent(int id)
        {
            var events = await _eventsService.DeleteEvent(id);
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
        }
    }
}
