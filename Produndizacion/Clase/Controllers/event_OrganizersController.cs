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
    }
}
