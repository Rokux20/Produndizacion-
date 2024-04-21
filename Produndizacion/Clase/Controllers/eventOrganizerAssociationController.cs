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
    public class eventOrganizerAssociationController : ControllerBase
    {
        private readonly IEventOrganizerAssociationService _eventOrganizerAssociationService;
        public eventOrganizerAssociationController(IEventOrganizerAssociationService eventOrganizerAssociationService)
        {
            _eventOrganizerAssociationService = eventOrganizerAssociationService;
        }
        [HttpGet]
        public async Task<ActionResult<List<EventOrganizerAssociation>>> GetAll()
        {
            return Ok(await _eventOrganizerAssociationService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EventOrganizerAssociation>> GetById(int id)
        {
            var eventOrganizerAssociation = await _eventOrganizerAssociationService.GetById(id);
            if (eventOrganizerAssociation == null)
            {
                return NotFound();
            }
            return Ok(eventOrganizerAssociation);
        }
        [HttpPost]
        public async Task<ActionResult<EventOrganizerAssociation>> CreateEventOrganizerAssociation([FromBody] EventOrganizerAssociation eventOrganizerAssociation)
        {
            return Ok(await _eventOrganizerAssociationService.CreateEventOrganizerAssociation(eventOrganizerAssociation.IdEvents, eventOrganizerAssociation.IdOrganizer));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<EventOrganizerAssociation>> UpdateEventOrganizerAssociation(int id, [FromBody] EventOrganizerAssociation eventOrganizerAssociation)
        {
            try
            {
                return Ok(await _eventOrganizerAssociationService.UpdateEventOrganizerAssociation(id, eventOrganizerAssociation.IdEvents, eventOrganizerAssociation.IdOrganizer));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventOrganizerAssociation>> DeleteEventOrganizerAssociation(int id)
        {
            var eventOrganizerAssociation = await _eventOrganizerAssociationService.DeleteEventOrganizerAssociation(id);
            if (eventOrganizerAssociation == null)
            {
                return NotFound();
            }
            return Ok(eventOrganizerAssociation);
        }

    }
}
