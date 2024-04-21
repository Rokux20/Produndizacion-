using Clase.Repositories;
using Clase.Models;

namespace Clase.Services
{

    public interface Ievent_Attendee_RegistrationService
    {
        Task<List<Event_Attendee_Registration>> GetAll();
        Task<Event_Attendee_Registration> GetById(int id);
        Task<Event_Attendee_Registration> Createevent_Attendee_Registration(int IdAttendee, int IdEvents, DateTime RegistrationDate);
        Task<Event_Attendee_Registration> Updateevent_Attendee_Registration(int IdRegistration, int? IdAttendee= null, int? IdEvents=null, DateTime? RegistrationDate=null);
        Task<Event_Attendee_Registration> Deleteevent_Attendee_Registration(int id);    
    }
    public class event_Attendee_RegistrationService : Ievent_Attendee_RegistrationService
    {
        private readonly IEventAttendeRegistrationRepository _event_Attendee_RegistrationRepository;
        public event_Attendee_RegistrationService(IEventAttendeRegistrationRepository event_Attendee_RegistrationRepository)
        {
            _event_Attendee_RegistrationRepository = event_Attendee_RegistrationRepository;
        }
        public async Task<Event_Attendee_Registration> Createevent_Attendee_Registration(int IdAttendee, int IdEvents, DateTime RegistrationDate)
        {
            return await _event_Attendee_RegistrationRepository.CreateEventAttendeRegistration(IdAttendee, IdEvents, RegistrationDate);
        }
        public async Task<List<Event_Attendee_Registration>> GetAll()
        {
            return await _event_Attendee_RegistrationRepository.GetAll();
        }
        public async Task<Event_Attendee_Registration> GetById(int id)
        {
            return await _event_Attendee_RegistrationRepository.GetById(id);
        }
        public async Task<Event_Attendee_Registration> Updateevent_Attendee_Registration(int IdRegistration, int? IdAttendee = null, int? IdEvents = null, DateTime? RegistrationDate = null)
        {
            Event_Attendee_Registration event_Attendee_Registration = await _event_Attendee_RegistrationRepository.GetById(IdRegistration);
            if (event_Attendee_Registration == null)
            {
                throw new Exception("Event_Attendee_Registration not found");
            }
            if (IdAttendee != null)
            {
                event_Attendee_Registration.IdAttendee = (int)IdAttendee;
            }
            if (IdEvents != null)
            {
                event_Attendee_Registration.IdEvents = (int)IdEvents;
            }
            if (RegistrationDate != null)
            {
                event_Attendee_Registration.RegistrationDate = (DateTime)RegistrationDate;
            }
            return await _event_Attendee_RegistrationRepository.UpdateEventAttendeRegistration(event_Attendee_Registration);
        }
        public async Task<Event_Attendee_Registration> Deleteevent_Attendee_Registration(int id)
        {
            Event_Attendee_Registration event_Attendee_Registration = await _event_Attendee_RegistrationRepository.GetById(id);
            if (event_Attendee_Registration == null)
            {
                throw new Exception("Event_Attendee_Registration not found");
            }
            return await _event_Attendee_RegistrationRepository.DeleteEventAttendeRegistration(event_Attendee_Registration);
        }



    }

}
