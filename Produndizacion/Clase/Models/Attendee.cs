using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clase.Models
{
    public class Attendee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAttendee { get; set; }


        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<Event_Attendee_Registration> event_Attendee_Registration  { get; set; }

        public  List<RoomAttendeeRegistration> roomAttendeeRegistration { get; set; }

    }

   
}
