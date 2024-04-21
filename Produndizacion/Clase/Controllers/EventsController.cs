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
    }
}
