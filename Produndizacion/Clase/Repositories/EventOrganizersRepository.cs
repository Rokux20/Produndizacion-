using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase.Repositories
{

    public interface IEventOrganizersRepository
    {
        Task<List<Event_Organizers>> GetAll();
        Task<Event_Organizers> GetById(int id);
        Task<Event_Organizers> CreateEventOrganizer( string First_name, string Last_name, string email, string phone);
        Task<Event_Organizers> UpdateEventOrganizer(Event_Organizers eventOrganizer);
        Task<Event_Organizers> DeleteEventOrganizer(Event_Organizers eventOrganizer);
    }
    public class EventOrganizersRepository: IEventOrganizersRepository
    {
        private readonly ProyectbContext _db;

        public EventOrganizersRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<Event_Organizers> CreateEventOrganizer( string First_name, string Last_name, string email, string phone)
        {
            Event_Organizers newEventOrganizer = new Event_Organizers
            {
               
                FirstName = First_name,
                LastName = Last_name,
                Email = email,
                Phone = phone
            };

            await _db.event_Organizers.AddAsync(newEventOrganizer);
            await _db.SaveChangesAsync();

            return newEventOrganizer;
        }

        public async Task<List<Event_Organizers>> GetAll()
        {
            return await _db.event_Organizers.ToListAsync();
        }

        public async Task<Event_Organizers> GetById(int id)
        {
            return await _db.event_Organizers.FirstOrDefaultAsync(x => x.IdOrganizer == id);
        }
        public async Task<Event_Organizers> UpdateEventOrganizer(Event_Organizers eventOrganizer)
        {
            _db.event_Organizers.Update(eventOrganizer);
            await _db.SaveChangesAsync();
            throw new NotImplementedException();
        }
        public async Task<Event_Organizers> DeleteEventOrganizer(Event_Organizers eventOrganizer)
        {
            throw new NotImplementedException();
        }
    }
}
