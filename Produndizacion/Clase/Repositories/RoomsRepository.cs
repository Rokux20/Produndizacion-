using Clase.Models;

namespace Clase.Repositories
{

    public interface IRoomsRepository
    {
        List<Rooms> GetAll();
        List<Rooms> Get(int id);

        void CreateRoom(Rooms rooms);
        void UpdateRoom(int id, Rooms rooms);
        void DeleteRoom(int id);
    }
    public class RoomsRepository: IRoomsRepository
    {
        public void CreateRoom(Rooms rooms)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rooms> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Rooms> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoom(int id, Rooms rooms)
        {
            throw new NotImplementedException();
        }
    

    }
    
    
}
