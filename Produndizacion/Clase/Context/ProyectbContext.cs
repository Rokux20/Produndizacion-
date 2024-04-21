using Microsoft.EntityFrameworkCore;
using Clase.Models;

namespace Clase.Context
{
    public class ProyectbContext : DbContext
    {

        public DbSet<Attendee> attendee { get; set; }
        public DbSet<Event_Attendee_Registration> event_Attendee_Registration { get; set; }
        public DbSet<Event_Organizers> event_Organizers { get; set; }
        public DbSet<EventOrganizerAssociation> eventOrganizerAssociation { get; set; }

        public DbSet<Events>events {  get; set; }
        public DbSet<RoomAttendeeRegistration> roomAttendeeRegistration {  get; set; }
        public DbSet<Rooms> rooms { get; set; }

        public ProyectbContext(DbContextOptions options) : base(options) 
        { 
        
        }

    }
}
