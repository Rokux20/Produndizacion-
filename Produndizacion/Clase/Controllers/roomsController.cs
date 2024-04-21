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
    public class roomsController : ControllerBase
    {
        private readonly IRoomsService _roomsService;
        public roomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Rooms>>> GetAll()
        {
            return Ok(await _roomsService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Rooms>> GetById(int id)
        {
            var rooms = await _roomsService.GetById(id);
            if (rooms == null)
            {
                return NotFound();
            }
            return Ok(rooms);
        }
    }
}
