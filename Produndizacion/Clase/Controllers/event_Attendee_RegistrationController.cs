using Clase.Models;
using Clase.Services;
using Clase.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class event_Attendee_RegistrationController : ControllerBase
    {
        private readonly Ievent_Attendee_RegistrationService _event_Attendee_RegistrationService;
        public event_Attendee_RegistrationController(Ievent_Attendee_RegistrationService event_Attendee_RegistrationService)
        {
            _event_Attendee_RegistrationService = event_Attendee_RegistrationService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Event_Attendee_Registration>>> GetAll()
        {
            return Ok(await _event_Attendee_RegistrationService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Event_Attendee_Registration>> GetById(int id)
        {
            var event_Attendee_Registration = await _event_Attendee_RegistrationService.GetById(id);
            if (event_Attendee_Registration == null)
            {
                return NotFound();
            }
            return Ok(event_Attendee_Registration);
        }
    }
}
