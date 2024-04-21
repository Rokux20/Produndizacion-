using Clase.Repositories;
using Clase.Models;
namespace Clase.Services
{
    public interface IEventOrganizerAssociationService
    {
        Task<List<EventOrganizerAssociation>> GetAll();
        Task<EventOrganizerAssociation> GetById(int id);
        Task<EventOrganizerAssociation> CreateEventOrganizerAssociation(int IdOrganizer, int IdEvents);
        Task<EventOrganizerAssociation> UpdateEventOrganizerAssociation(int id, int? IdOrganizer = null, int? IdEvents = null);
        Task<EventOrganizerAssociation> DeleteEventOrganizerAssociation(int id);

        
    }
    public class eventOrganizerAssociationService : IEventOrganizerAssociationService
    {
        private readonly IEventOrganizersAssociationRepository _eventOrganizerAssociationRepository;
        public eventOrganizerAssociationService(IEventOrganizersAssociationRepository eventOrganizerAssociationRepository)
        {
            _eventOrganizerAssociationRepository = eventOrganizerAssociationRepository;
        }
        public async Task<EventOrganizerAssociation> CreateEventOrganizerAssociation(int IdOrganizer, int IdEvents)
        {
            return await _eventOrganizerAssociationRepository.CreateEventOrganizersAssociation(IdOrganizer, IdEvents);
        }
        public async Task<List<EventOrganizerAssociation>> GetAll()
        {
            return await _eventOrganizerAssociationRepository.GetAll();
        }
        public async Task<EventOrganizerAssociation> GetById(int id)
        {
            return await _eventOrganizerAssociationRepository.GetById(id);
        }
        public async Task<EventOrganizerAssociation> UpdateEventOrganizerAssociation(int id, int? IdOrganizer = null, int? IdEvents = null)
        {
            EventOrganizerAssociation eventOrganizerAssociation = await _eventOrganizerAssociationRepository.GetById(id);
            if (eventOrganizerAssociation == null)
            {
                throw new Exception("EventOrganizerAssociation not found");
            }
            if (IdOrganizer != null)
            {
                eventOrganizerAssociation.IdOrganizer = (int)IdOrganizer;
            }
            if (IdEvents != null)
            {
                eventOrganizerAssociation.IdEvents = (int)IdEvents;
            }
            return await _eventOrganizerAssociationRepository.UpdateEventOrganizersAssociation(eventOrganizerAssociation);
        }
        public async Task<EventOrganizerAssociation> DeleteEventOrganizerAssociation(int id)
        {
            EventOrganizerAssociation eventOrganizerAssociation = await _eventOrganizerAssociationRepository.GetById(id);
            if (eventOrganizerAssociation == null)
            {
                throw new Exception("EventOrganizerAssociation not found");
            }
            return await _eventOrganizerAssociationRepository.DeleteEventOrganizersAssociation(eventOrganizerAssociation);
        }
    }
}
