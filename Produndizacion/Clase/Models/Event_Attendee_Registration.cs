using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Clase.Models
{
    public class Event_Attendee_Registration


    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistration { get; set; }

        public int IdAttendee { get; set; }

        public Attendee attendee { get; set; } /// llave foranea  de Attendee

        public int IdEvents { get; private set; }
        
        public Events events { get; set; }  //llave foranea de Events

        public DateTime RegistrationDate { get;}
    }
    
}
