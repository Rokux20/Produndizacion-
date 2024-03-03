using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class RoomAttendeeRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   

        public int IdAttendeeR{ get; set; }

        public int IdAttendee { get; set; }
        public Attendee attendee { get; set; } /// llave foranea 

        public int IdRoom { get; set; }
        public Rooms rooms { get; set; } /// llave foranea 

        public DateTime RegistrationDate { get; set; }
    }
}
