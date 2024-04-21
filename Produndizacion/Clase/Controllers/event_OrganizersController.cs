using Clase.Models;
using Clase.Services;
using Clase.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class event_OrganizersController : ControllerBase
    {
        private readonly IEvent_Organizersservice _event_OrganizersService;
        public event_OrganizersController(IEvent_Organizersservice event_OrganizersService)
        {
            _event_OrganizersService = event_OrganizersService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Event_Organizers>>> GetAll()
        {
            return Ok(await _event_OrganizersService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Event_Organizers>> GetById(int id)
        {
            var event_Organizers = await _event_OrganizersService.GetById(id);
            if (event_Organizers == null)
            {
                return NotFound();
            }
            return Ok(event_Organizers);
        }
        [HttpPost]
        public async Task<ActionResult<Event_Organizers>> CreateEvent_Organizers([FromBody] Event_Organizers event_Organizers)
        {
            return Ok(await _event_OrganizersService.CreateEvent_Organizers(event_Organizers.FirstName, event_Organizers.LastName, event_Organizers.Email, event_Organizers.Phone));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Event_Organizers>> UpdateEvent_Organizers(int id, [FromBody] Event_Organizers event_Organizers)
        {
            try
            {
                return Ok(await _event_OrganizersService.UpdateEvent_Organizers(id, event_Organizers.FirstName, event_Organizers.LastName, event_Organizers.Email, event_Organizers.Phone));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{id}")] 
        public async Task<ActionResult<Event_Organizers>> DeleteEvent_Organizers(int id)
        {
            var event_Organizers = await _event_OrganizersService.DeleteEvent_Organizers(id);
            if (event_Organizers == null)
            {
                return NotFound();
            }
            return Ok(event_Organizers);
        }
    }
}
