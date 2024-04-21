using Clase.Repositories;
using Clase.Models;
namespace Clase.Services
{
    public interface IEventsService
    {
        Task<List<Events>> GetAll();
        Task<Events> GetById(int id);
        Task<Events> CreateEvent(string Name, string Description, DateTime Date, int MaxCapacity);
        Task<Events> UpdateEvent(int id, string? Name = null, string? Description = null, DateTime? Date = null, int? MaxCapacity = null);
        Task<Events> DeleteEvent(int id);
    }
    public class eventsService : IEventsService
    {
        private readonly IEventsRepository _eventsRepository;
        public eventsService(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }
        public async Task<Events> CreateEvent(string Name, string Description, DateTime Date, int MaxCapacity)
        {
            return await _eventsRepository.CreateEvent(Name, Description, Date, MaxCapacity);
        }
        public async Task<List<Events>> GetAll()
        {
            return await _eventsRepository.GetAll();
        }
        public async Task<Events> GetById(int id)
        {
            return await _eventsRepository.GetById(id);
        }
        public async Task<Events> UpdateEvent(int id, string? Name = null, string? Description = null, DateTime? Date = null, int? MaxCapacity = null)
        {
            Events events = await _eventsRepository.GetById(id);
            if (events == null)
            {
                throw new Exception("Event not found");
            }
            if (Name != null)
            {
                events.Name = Name;
            }
            if (Description != null)
            {
                events.Description = Description;
            }
            if (Date != null)
            {
                events.Date = (DateTime)Date;
            }
            if (MaxCapacity != null)
            {
                events.MaxCapacity = (int)MaxCapacity;
            }
            return await _eventsRepository.UpdateEvent(events);
        }
        public async Task<Events> DeleteEvent(int id)
        {
            Events events = await _eventsRepository.GetById(id);
            if (events == null)
            {
                throw new Exception("Event not found");
            }
            return await _eventsRepository.DeleteEvent(events);
        }
    }
}
