using Clase.Models;

namespace Clase.Repositories
{

    public interface IEventOrganizersRepository
    {

        List<Event_Organizers> GetAll();
        List<Event_Organizers> Get(int id);

        void CreateEventOrganizers(Event_Organizers eventOrganizers);
        void UpdateEventOrganizers(int id, Event_Organizers eventOrganizers);
        void DeleteEventOrganizers(int id);
    }
    public class EventOrganizersRepository: IEventOrganizersRepository
    {
        public void CreateEventOrganizers(Event_Organizers eventOrganizers)
        {
            throw new NotImplementedException();
        }

        public void DeleteEventOrganizers(int id)
        {
            throw new NotImplementedException();
        }

        public List<Event_Organizers> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Event_Organizers> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEventOrganizers(int id, Event_Organizers eventOrganizers)
        {
            throw new NotImplementedException();
        }
    

    }
}
