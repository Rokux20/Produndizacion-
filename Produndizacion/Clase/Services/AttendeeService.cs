using Clase.Models;
using Clase.Repositories;

namespace Clase.Services
{
    public interface IAttendeeService
    {
        Task<List<Attendee>> GetAll();
        Task<Attendee> GetById(int id);
        Task<Attendee> CreateAttendee(string First_name, string Last_name, string email, string phone);
        Task<Attendee> UpdateAttendee(int id, string? First_name = null, string?  Last_name = null, string? email = null, string? phone = null);
        Task<Attendee> DeleteAttendee(int id);
    }
    public class AttendeeService : IAttendeeService
    {
        private readonly IAttendeeRepository _attendeeRepository;
        public AttendeeService(IAttendeeRepository attendeeRepository)
        {
            _attendeeRepository = attendeeRepository;
        }
        public async Task<Attendee> CreateAttendee(string First_name, string Last_name, string email, string phone)
        {
            return await _attendeeRepository.CreateAttendee(First_name, Last_name, email, phone);
        }
        public async Task<List<Attendee>> GetAll()
        {
            return await _attendeeRepository.GetAll();
        }
        public async Task<Attendee> GetById(int id)
        {
            return await _attendeeRepository.GetById(id);
        }
        public async Task<Attendee> UpdateAttendee(int id, string? First_name = null, string? Last_name = null, string? email = null, string? phone = null)
        {
            Attendee attendee = await _attendeeRepository.GetById(id);
            if (attendee == null)
            {
                throw new Exception("Attendee not found");
            }
            if (First_name != null)
            {
                attendee.First_Name = First_name;
            }
            if (Last_name != null)
            {
                attendee.Last_Name = Last_name;
            }
            if (email != null)
            {
                attendee.Email = email;
            }
            if (phone != null)
            {
                attendee.Phone = phone;
            }
            return await _attendeeRepository.UpdateAttendee(attendee);
        }
        public async Task<Attendee> DeleteAttendee(int id)
        {
            Attendee attendee = await _attendeeRepository.GetById(id);
            if (attendee == null)
            {
                throw new Exception("Attendee not found");
            }
            return await _attendeeRepository.DeleteAttendee(attendee);
        }
    }
}
