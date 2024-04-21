using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase.Repositories

{

    public interface IEventOrganizersAssociationRepository
    {
        Task<List<EventOrganizerAssociation>> GetAll();
        Task<EventOrganizerAssociation> GetById(int id);
        Task<EventOrganizerAssociation> CreateEventOrganizersAssociation( int IdEvents, int IdOrganizer);
        Task<EventOrganizerAssociation> UpdateEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation);
        Task<EventOrganizerAssociation> DeleteEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation);

     

    }

    public class EventOrganizersAssociationRepository: IEventOrganizersAssociationRepository
    {
        private readonly ProyectbContext _db;

        public EventOrganizersAssociationRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<EventOrganizerAssociation> CreateEventOrganizersAssociation( int IdEvents, int IdOrganizer)
        {
            EventOrganizerAssociation newEventOrganizersAssociation = new EventOrganizerAssociation
            {
                
                IdEvents = IdEvents,
                IdOrganizer = IdOrganizer
            };

            await _db.eventOrganizerAssociation.AddAsync(newEventOrganizersAssociation);
            _db.SaveChanges();

            return newEventOrganizersAssociation;
        }

        public async Task<List<EventOrganizerAssociation>> GetAll()
        {
            return await _db.eventOrganizerAssociation.ToListAsync();
        }
        public async Task<EventOrganizerAssociation> GetById(int id)
        {
            return await _db.eventOrganizerAssociation.FirstOrDefaultAsync(x => x.IdEventOrg == id);
        }
        public async Task<EventOrganizerAssociation> UpdateEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation)
        {
            _db.eventOrganizerAssociation.Update(eventOrganizerAssociation);
            await _db.SaveChangesAsync();
            return eventOrganizerAssociation;
        }
        public async Task<EventOrganizerAssociation> DeleteEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation)
        {
            eventOrganizerAssociation.deleted = true;
            _db.eventOrganizerAssociation.Update(eventOrganizerAssociation);
            await _db.SaveChangesAsync();
            return eventOrganizerAssociation;
            
        }
    }
    
}
