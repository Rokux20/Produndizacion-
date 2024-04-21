using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;
namespace Clase.Repositories
{

    public interface IEventsRepository
    {
        Task<List<Events>> GetAll();
        Task<Events> GetById(int id);
        Task<Events> CreateEvent( string Name, string Description, DateTime Date, int MaxCapacity);
        Task<Events> UpdateEvent(Events events);
        Task<Events> DeleteEvent(Events events);
    }

    public class EventsRepository: IEventsRepository
    {
       private readonly ProyectbContext _db;

        public EventsRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<Events> CreateEvent( string Name, string Description, DateTime Date, int MaxCapacity)
        {
            Events newEvent = new Events
            {
               
                Name = Name,
                Description = Description,
                Date = Date,
                MaxCapacity = MaxCapacity
            };

            await _db.events.AddAsync(newEvent);
            _db.SaveChanges();

            return newEvent;
        }

        public async Task<List<Events>> GetAll()
        {
            return await _db.events.ToListAsync();
        }

        public async Task<Events> GetById(int id)
        {
            return await _db.events.FirstOrDefaultAsync(x => x.IdEvents == id);
        }

        public async Task<Events> UpdateEvent(Events events)
        {
            _db.events.Update(events);
            await _db.SaveChangesAsync();
            return events;
        }

        public async Task<Events> DeleteEvent(Events events)
        {
           
            events.deleted = true;
            _db.events.Update(events);
            await _db.SaveChangesAsync();
            return events;
        }
    }
    
}
