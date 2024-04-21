using Clase.Models;
using Clase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeeController : ControllerBase
    {
        private readonly IAttendeeService _attendeeService;
        public AttendeeController(IAttendeeService attendeeService)
        {
            _attendeeService = attendeeService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Attendee>>> GetAll()
        {
            return Ok(await _attendeeService.GetAll());
        }
        [HttpGet("{attendeeId}")]
        public async Task<ActionResult<Attendee>> GetById(int attendeeId)
        {
            var attendee = await _attendeeService.GetById(attendeeId);
            if (attendee == null)
            {
                return NotFound();
            }
            return Ok(attendee);
        }
        [HttpPost]
        public async Task<ActionResult<Attendee>> CreateAttendee([FromBody] Attendee attendee)
        {
            return Ok(await _attendeeService.CreateAttendee(attendee.First_Name, attendee.Last_Name, attendee.Email, attendee.Phone));
        }
        [HttpPut("{attendeeId}")]
        public async Task<ActionResult<Attendee>> UpdateAttendee(int attendeeId, [FromBody] Attendee attendee)
        {
            try
            {
                return Ok(await _attendeeService.UpdateAttendee(attendeeId, attendee.First_Name, attendee.Last_Name, attendee.Email, attendee.Phone));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{attendeeId}")]
        public async Task<ActionResult<Attendee>> DeleteAttendee(int attendeeId)
        {
            var attendee = await _attendeeService.DeleteAttendee(attendeeId);
            if (attendee == null)
            {
                return NotFound();
            }
            return Ok(attendee);
        }



    }
}
