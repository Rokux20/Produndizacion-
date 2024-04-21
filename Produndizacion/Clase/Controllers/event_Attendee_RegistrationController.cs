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
        [HttpPost]
        public async Task<ActionResult<Event_Attendee_Registration>> CreateEventAttendeRegistration([FromBody] Event_Attendee_Registration event_Attendee_Registration)
        {
            return Ok(await _event_Attendee_RegistrationService.Createevent_Attendee_Registration(event_Attendee_Registration.IdAttendee, event_Attendee_Registration.IdEvents, event_Attendee_Registration.RegistrationDate));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Event_Attendee_Registration>> UpdateEventAttendeRegistration(int id, [FromBody] Event_Attendee_Registration event_Attendee_Registration)
        {
            try
            {
                return Ok(await _event_Attendee_RegistrationService.Updateevent_Attendee_Registration(id, event_Attendee_Registration.IdAttendee, event_Attendee_Registration.IdEvents, event_Attendee_Registration.RegistrationDate));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Event_Attendee_Registration>> DeleteEventAttendeRegistration(int id)
        {
            var event_Attendee_Registration = await _event_Attendee_RegistrationService.Deleteevent_Attendee_Registration(id);
            if (event_Attendee_Registration == null)
            {
                return NotFound();
            }
            return Ok(event_Attendee_Registration);
        }
        
    }

}
