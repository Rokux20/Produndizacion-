using Azure.Core;
using Clase.Context;
using Clase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;  

namespace Clase.Repositories
{

    public interface IAttendeeRepository
    {
        Task<List<Attendee>> GetAll();
        Task<Attendee> GetById(int id);
        Task<Attendee> CreateAttendee(string First_name, string Last_name, string email, string phone);
        Task<Attendee> UpdateAttendee(Attendee attendee);
        Task<Attendee> DeleteAttendee(Attendee attendee);
    }


    public class AttendeRepository : IAttendeeRepository
    {
        private readonly ProyectbContext _db;

        public AttendeRepository(ProyectbContext db)
        {
            _db = db;
        }

        public async Task<Attendee> CreateAttendee(string First_name, string Last_name, string email, string phone)
        {
            Attendee  newAttendee = new Attendee
            {
                First_Name = First_name,
                Last_Name = Last_name,
                Email = email,
                Phone = phone
            };

                await _db.attendee.AddAsync(newAttendee);
                _db.SaveChanges();

            return newAttendee;
        }

        public async Task<List<Attendee>> GetAll()
        {
            return await _db.attendee.ToListAsync();
        }
        public async Task<Attendee> GetById(int id)
        {
            return await _db.attendee.FirstOrDefaultAsync(x => x.IdAttendee == id);
        }
        
        public async Task<Attendee> UpdateAttendee(Attendee attendee)
        {
            _db.attendee.Update(attendee);
            await _db.SaveChangesAsync();
            return attendee;
        }
        public async Task<Attendee> DeleteAttendee(Attendee attendee)
        {
            
            attendee.deleted = true;
            _db.attendee.Update(attendee);
            await _db.SaveChangesAsync();
            return attendee;
        }

    }
}
