using Clase.Models;
using Clase.Repositories;

namespace Clase.Services
{
    public interface IRoomsService
    {
        Task<List<Rooms>> GetAll();
        Task<Rooms> GetById(int id);
        Task<Rooms> CreateRoom(string Name, int MaxCapacity);
        Task<Rooms> UpdateRoom(int IdRoom, string? Name = null, int? MaxCapacity = null);
        Task<Rooms> DeleteRoom(Rooms room);
    }
    public class RoomsService : IRoomsService
    {
        private readonly IRoomsRepository _roomsRepository;
        public RoomsService(IRoomsRepository roomsRepository)
        {
            _roomsRepository = roomsRepository;
        }
        public async Task<Rooms> CreateRoom(string Name, int MaxCapacity)
        {
            return await _roomsRepository.CreateRoom(Name, MaxCapacity);
        }
        public async Task<List<Rooms>> GetAll()
        {
            return await _roomsRepository.GetAll();
        }
        public async Task<Rooms> GetById(int id)
        {
            return await _roomsRepository.GetById(id);
        }
        public async Task<Rooms> UpdateRoom(int IdRoom, string? Name = null, int? MaxCapacity = null)
        {
            Rooms room = await _roomsRepository.GetById(IdRoom);
            if (room == null)
            {
                throw new Exception("Room not found");
            }
            if (Name != null)
            {
                room.Name = Name;
            }
            if (MaxCapacity != null)
            {
                room.MaxCapacity = (int)MaxCapacity;
            }
            return await _roomsRepository.UpdateRoom(room);
        }
        public async Task<Rooms> DeleteRoom(Rooms room)
        {
            return await _roomsRepository.DeleteRoom(room);
        }
    }
}
