using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase.Repositories
{

    public interface IRoomsRepository
    {
        Task<List<Rooms>> GetAll();
        Task<Rooms> GetById(int id);
        Task<Rooms> CreateRoom(string Name, int MaxCapacity);
        Task<Rooms> UpdateRoom(Rooms room);
        Task<Rooms> DeleteRoom(Rooms room);
    }
    public class RoomsRepository: IRoomsRepository
    {
        private readonly ProyectbContext _db;

        public RoomsRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<Rooms> CreateRoom(string Name, int MaxCapacity)
        {
            Rooms newRoom = new Rooms
            {
                Name = Name,
                MaxCapacity = MaxCapacity
            };

            await _db.rooms.AddAsync(newRoom);
            _db.SaveChanges();

            return newRoom;
        }

        public async Task<List<Rooms>> GetAll()
        {
            return await _db.rooms.ToListAsync();
        }
        public async Task<Rooms> GetById(int id)
        {
            return await _db.rooms.FirstOrDefaultAsync(x => x.IdRoom == id);
        }
        
        public async Task<Rooms> UpdateRoom(Rooms room)
        {
            _db.rooms.Update(room);
            await _db.SaveChangesAsync();
            return room;
        }
        public async Task<Rooms> DeleteRoom(Rooms room)
        {
            room.deleted = true;
            _db.rooms.Update(room);
            await _db.SaveChangesAsync();
            return room;
        }
       
    }
    
    
}
