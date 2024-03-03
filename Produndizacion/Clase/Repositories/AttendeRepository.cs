using Clase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;  

namespace Clase.Repositories
{

    public interface IAttendeeRepository
    {
        List<Attendee> GetAll();
        List<Attendee> GetByFirstName(int id);

        void CreateAttendee (Attendee attendee);
        void UpdateAttendee (int id, Attendee attendee);
        void DeleteAttendee (int id);
    }


    public class AttendeRepository : IAttendeeRepository
    {
        public void CreateAttendee(Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public void DeleteAttendee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Attendee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Attendee> GetByFirstName(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAttendee(int id, Attendee attendee)
        {
            throw new NotImplementedException();
        }
    }
}
