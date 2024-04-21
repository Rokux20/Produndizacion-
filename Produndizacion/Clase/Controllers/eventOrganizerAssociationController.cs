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
    }
}
