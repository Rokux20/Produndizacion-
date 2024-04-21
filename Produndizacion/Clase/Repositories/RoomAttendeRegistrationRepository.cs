using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase.Repositories
{

    public interface IRoomAttendeRegistrationRepository
    {
        Task<List<RoomAttendeeRegistration>> GetAll();
        Task<RoomAttendeeRegistration> GetById(int id);
        Task<RoomAttendeeRegistration> CreateRoomAttendeeRegistration( int IdAttendee, int IdRoom, DateTime RegistrationDate);
        Task<RoomAttendeeRegistration> UpdateRoomAttendeeRegistration(RoomAttendeeRegistration roomAttendeeRegistration);
        Task<RoomAttendeeRegistration> DeleteRoomAttendeeRegistration(RoomAttendeeRegistration roomAttendeeRegistration);
    }
    public class RoomAttendeRegistrationRepository: IRoomAttendeRegistrationRepository
    {
        private readonly ProyectbContext _db;
        public RoomAttendeRegistrationRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<RoomAttendeeRegistration> CreateRoomAttendeeRegistration( int IdAttendee, int IdRoom, DateTime RegistrationDate)
        {
            RoomAttendeeRegistration newRoomAttendeeRegistration = new RoomAttendeeRegistration
            {
               
                IdAttendee = IdAttendee,
                IdRoom = IdRoom,
                RegistrationDate = RegistrationDate
            };

            await _db.roomAttendeeRegistration.AddAsync(newRoomAttendeeRegistration);
            _db.SaveChanges();

            return newRoomAttendeeRegistration;
        }
        public async Task<List<RoomAttendeeRegistration>> GetAll()
        {
            return await _db.roomAttendeeRegistration.ToListAsync();
        }
        public async Task<RoomAttendeeRegistration> GetById(int id)
        {
            return await _db.roomAttendeeRegistration.FirstOrDefaultAsync(x => x.IdAttendeeR == id);
        }
        public async Task<RoomAttendeeRegistration> UpdateRoomAttendeeRegistration(RoomAttendeeRegistration roomAttendeeRegistration)
        {
            _db.roomAttendeeRegistration.Update(roomAttendeeRegistration);
            await _db.SaveChangesAsync();
            throw new NotImplementedException();
        }
        public async Task<RoomAttendeeRegistration> DeleteRoomAttendeeRegistration(RoomAttendeeRegistration roomAttendeeRegistration)
        {
            throw new NotImplementedException();
        }
    }   
    
}
