using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Clase.Models
{
    public class Event_Attendee_Registration


    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistration { get; set; }

        [ForeignKey("IdAttendee")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdAttendee { get; set; }

        [ForeignKey("IdEvents")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdEvents { get;  set; }

        public bool deleted = false;

        public DateTime RegistrationDate { get; set; }
    }
    
}
