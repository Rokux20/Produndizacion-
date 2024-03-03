using Clase.Models;
namespace Clase.Repositories
{

    public interface IEventsRepository
    {
        List<Events> GetAll();
        List<Events> Get(int id);

        void CreateEvent(Events events);
        void UpdateEvent(int id, Events events);
        void DeleteEvent(int id);
    }

    public class EventsRepository: IEventsRepository
    {
        public void CreateEvent(Events events)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Events> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Events> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(int id, Events events)
        {
            throw new NotImplementedException();
        }

    }
    
}
