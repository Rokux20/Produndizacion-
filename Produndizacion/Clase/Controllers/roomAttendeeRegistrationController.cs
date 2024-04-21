using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clase.Models;
using Clase.Services;
using Clase.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Clase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class roomAttendeeRegistrationController : ControllerBase
    {
        private readonly IroomAttendeeRegistrationService _roomAttendeeRegistrationService;
        public roomAttendeeRegistrationController(IroomAttendeeRegistrationService roomAttendeeRegistrationService)
        {
            _roomAttendeeRegistrationService = roomAttendeeRegistrationService;
        }
        [HttpGet]
        public async Task<ActionResult<List<RoomAttendeeRegistration>>> GetAll()
        {
            return Ok(await _roomAttendeeRegistrationService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomAttendeeRegistration>> GetById(int id)
        {
            var roomAttendeeRegistration = await _roomAttendeeRegistrationService.GetById(id);
            if (roomAttendeeRegistration == null)
            {
                return NotFound();
            }
            return Ok(roomAttendeeRegistration);
        }
    }
}
