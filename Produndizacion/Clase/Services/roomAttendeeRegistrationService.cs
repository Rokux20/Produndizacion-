using Clase.Repositories;
using Clase.Models;

namespace Clase.Services
{   
    public interface IroomAttendeeRegistrationService
    {
        
        Task<List<RoomAttendeeRegistration>> GetAll();
        Task<RoomAttendeeRegistration> GetById(int id);
        Task<RoomAttendeeRegistration> CreateRoomAttendeeRegistration(int IdAttendee, int IdRoom, DateTime RegistrationDate);
        Task<RoomAttendeeRegistration> UpdateRoomAttendeeRegistration(int IdAttendeeR, int? IdAttendee=null, int? IdRoom= null, DateTime? RegistrationDate=null);
        Task<RoomAttendeeRegistration> DeleteRoomAttendeeRegistration(int id);
    }
    public class roomAttendeeRegistrationService : IroomAttendeeRegistrationService
    {
        private readonly IRoomAttendeRegistrationRepository _roomAttendeeRegistrationRepository;
        public roomAttendeeRegistrationService(IRoomAttendeRegistrationRepository roomAttendeeRegistrationRepository)
        {
            _roomAttendeeRegistrationRepository = roomAttendeeRegistrationRepository;
        }
        public async Task<RoomAttendeeRegistration> CreateRoomAttendeeRegistration(int IdAttendee, int IdRoom, DateTime RegistrationDate)
        {
            return await _roomAttendeeRegistrationRepository.CreateRoomAttendeeRegistration(IdAttendee, IdRoom, RegistrationDate);
        }
        public async Task<List<RoomAttendeeRegistration>> GetAll()
        {
            return await _roomAttendeeRegistrationRepository.GetAll();
        }
        public async Task<RoomAttendeeRegistration> GetById(int id)
        {
            return await _roomAttendeeRegistrationRepository.GetById(id);
        }
        public async Task<RoomAttendeeRegistration> UpdateRoomAttendeeRegistration(int IdAttendeeR, int? IdAttendee = null, int? IdRoom = null, DateTime? RegistrationDate = null)
        {
            RoomAttendeeRegistration roomAttendeeRegistration = await _roomAttendeeRegistrationRepository.GetById(IdAttendeeR);
            if (roomAttendeeRegistration == null)
            {
                throw new Exception("RoomAttendeeRegistration not found");
            }
            if (IdAttendee != null)
            {
                roomAttendeeRegistration.IdAttendee = (int)IdAttendee;
            }
            if (IdRoom != null)
            {
                roomAttendeeRegistration.IdRoom = (int)IdRoom;
            }
            if (RegistrationDate != null)
            {
                roomAttendeeRegistration.RegistrationDate = (DateTime)RegistrationDate;
            }
            return await _roomAttendeeRegistrationRepository.UpdateRoomAttendeeRegistration(roomAttendeeRegistration);
        }
        public async Task<RoomAttendeeRegistration> DeleteRoomAttendeeRegistration(int id)
        {
            RoomAttendeeRegistration roomAttendeeRegistration = await _roomAttendeeRegistrationRepository.GetById(id);
            if (roomAttendeeRegistration == null)
            {
                throw new Exception("RoomAttendeeRegistration not found");
            }
            return await _roomAttendeeRegistrationRepository.DeleteRoomAttendeeRegistration(roomAttendeeRegistration);
        }
    }
}
