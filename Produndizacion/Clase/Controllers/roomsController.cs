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
        [HttpPost]
        public async Task<ActionResult<Rooms>> CreateRoom([FromBody] Rooms rooms)
        {
            return Ok(await _roomsService.CreateRoom(rooms.Name, rooms.MaxCapacity));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Rooms>> UpdateRoom(int id, [FromBody] Rooms rooms)
        {
            try
            {
                return Ok(await _roomsService.UpdateRoom(id, rooms.Name, rooms.MaxCapacity));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rooms>> DeleteRoom(Rooms  room)
        {
            var rooms = await _roomsService.DeleteRoom(room);
            if (rooms == null)
            {
                return NotFound();
            }
            return Ok(rooms);
        }

    }
}
