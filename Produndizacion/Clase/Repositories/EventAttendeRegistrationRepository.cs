using Clase.Models;

namespace Clase.Repositories
{

    public interface IEventAttendeRegistrationRepository
    {

        List<Event_Attendee_Registration> GetAll();
        List<Event_Attendee_Registration> Get(int id);


        void CreateEventAttendeRegistration(Event_Attendee_Registration eventAttendeeRegistration);
        void UpdateEventAttendeRegistration(int id, Event_Attendee_Registration eventAttendeeRegistration);
        void DeleteEventAttendeRegistration(int id);
    }

    public class EventAttendeRegistrationRepository: IEventAttendeRegistrationRepository
    {
        public void CreateEventAttendeRegistration(Event_Attendee_Registration eventAttendeeRegistration)
        {
            throw new NotImplementedException();
        }

        public void DeleteEventAttendeRegistration(int id)
        {
            throw new NotImplementedException();
        }

        public List<Event_Attendee_Registration> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Event_Attendee_Registration> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEventAttendeRegistration(int id, Event_Attendee_Registration eventAttendeeRegistration)
        {
            throw new NotImplementedException();
        }

    }
}
