using Clase.Models;

namespace Clase.Repositories
{

    interface IRoomAttendeRefistrationRepository
    {
        List<RoomAttendeeRegistration> GetAll();
        List<RoomAttendeeRegistration> Get(int id);

        void CreateRoomAttendeRefistration(RoomAttendeeRegistration roomAttendeeRegistration);
        void UpdateRoomAttendeRefistration(int id, RoomAttendeeRegistration roomAttendeeRegistration);
        void DeleteRoomAttendeRefistration(int id);
    }
    public class RoomAttendeRefistrationRepository: IRoomAttendeRefistrationRepository
    {
        public void CreateRoomAttendeRefistration(RoomAttendeeRegistration roomAttendeeRegistration)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoomAttendeRefistration(int id)
        {
            throw new NotImplementedException();
        }

        public List<RoomAttendeeRegistration> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RoomAttendeeRegistration> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoomAttendeRefistration(int id, RoomAttendeeRegistration roomAttendeeRegistration)
        {
            throw new NotImplementedException();
        }
    

    }   
    
}
