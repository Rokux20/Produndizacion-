using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase.Repositories
{

    public interface IEventAttendeRegistrationRepository
    {   
        Task<List<Event_Attendee_Registration>> GetAll();
        Task<Event_Attendee_Registration> GetById(int id);
        Task<Event_Attendee_Registration> CreateEventAttendeRegistration(int IdAttendee, int IdEvents, DateTime RegistrationDate);
        Task<Event_Attendee_Registration> UpdateEventAttendeRegistration(Event_Attendee_Registration event_Attendee_Registration);
        Task<Event_Attendee_Registration> DeleteEventAttendeRegistration(Event_Attendee_Registration event_Attendee_Registration);
    }

    public class EventAttendeRegistrationRepository : IEventAttendeRegistrationRepository
    {
        private readonly ProyectbContext _db;

        public EventAttendeRegistrationRepository(ProyectbContext db)
        {
            _db = db;
        }

       public async Task<Event_Attendee_Registration> CreateEventAttendeRegistration(int IdAttendee, int IdEvents, DateTime RegistrationDate)
        {
            Event_Attendee_Registration newEventAttendeeRegistration = new Event_Attendee_Registration
            {
                IdAttendee = IdAttendee,
                IdEvents = IdEvents,
                RegistrationDate = RegistrationDate
            };

            await _db.event_Attendee_Registration.AddAsync(newEventAttendeeRegistration);
            _db.SaveChanges();

            return newEventAttendeeRegistration;
        }   

        public async Task<List<Event_Attendee_Registration>> GetAll()
        {
            return await _db.event_Attendee_Registration.ToListAsync();
        }
        public async Task<Event_Attendee_Registration> GetById(int id)
        {
            return await _db.event_Attendee_Registration.FirstOrDefaultAsync(x => x.IdRegistration == id);
        }
        public async Task<Event_Attendee_Registration> UpdateEventAttendeRegistration(Event_Attendee_Registration event_Attendee_Registration)
        {
            _db.event_Attendee_Registration.Update(event_Attendee_Registration);
            await _db.SaveChangesAsync();
            return event_Attendee_Registration;
            
        }
        public async Task<Event_Attendee_Registration> DeleteEventAttendeRegistration(Event_Attendee_Registration event_Attendee_Registration)
        {
            event_Attendee_Registration.deleted = true;
            _db.event_Attendee_Registration.Update(event_Attendee_Registration);
            await _db.SaveChangesAsync();
            return event_Attendee_Registration;
        }
        

    }
}
