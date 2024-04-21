using Clase.Models;
using Clase.Repositories;

namespace Clase.Services
{
    public interface IEvent_Organizersservice
    {
        Task<List<Event_Organizers>> GetAll();
        Task<Event_Organizers> GetById(int id);
        Task<Event_Organizers> CreateEvent_Organizers(string First_name, string Last_name, string email, string phone);
        Task<Event_Organizers> UpdateEvent_Organizers(int id, string? First_name = null, string?  Last_name = null, string? email = null, string? phone = null);
        Task<Event_Organizers> DeleteEvent_Organizers(int id);
    }
    public class event_Organizersservice : IEvent_Organizersservice
    {
        private readonly IEventOrganizersRepository _event_OrganizersRepository;
        public event_Organizersservice(IEventOrganizersRepository event_OrganizersRepository)
        {
            _event_OrganizersRepository = event_OrganizersRepository;
        }
        public async Task<Event_Organizers> CreateEvent_Organizers(string First_name, string Last_name, string email, string phone)
        {
            return await _event_OrganizersRepository.CreateEventOrganizer(First_name, Last_name, email, phone);
        }
        public async Task<List<Event_Organizers>> GetAll()
        {
            return await _event_OrganizersRepository.GetAll();
        }
        public async Task<Event_Organizers> GetById(int id)
        {
            return await _event_OrganizersRepository.GetById(id);
        }
        public async Task<Event_Organizers> UpdateEvent_Organizers(int id, string? First_name = null, string? Last_name = null, string? email = null, string? phone = null)
        {
            Event_Organizers event_Organizers = await _event_OrganizersRepository.GetById(id);
            if (event_Organizers == null)
            {
                throw new Exception("Event_Organizers not found");
            }
            if (First_name != null)
            {
                event_Organizers.FirstName = First_name;
            }
            if (Last_name != null)
            {
                event_Organizers.LastName = Last_name;
            }
            if (email != null)
            {
                event_Organizers.Email = email;
            }
            if (phone != null)
            {
                event_Organizers.Phone = phone;
            }
            return await _event_OrganizersRepository.UpdateEventOrganizer(event_Organizers);
        }
        public async Task<Event_Organizers> DeleteEvent_Organizers(int id)
        {
            Event_Organizers event_Organizers = await _event_OrganizersRepository.GetById(id);
            if (event_Organizers == null)
            {
                throw new Exception("Event_Organizers not found");
            }
            return await _event_OrganizersRepository.DeleteEventOrganizer(event_Organizers);
        }
    }
}
