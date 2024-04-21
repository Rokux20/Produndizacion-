using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class RoomAttendeeRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   

        public int IdAttendeeR{ get; set; }

        [ForeignKey("IdAttendee")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdAttendee { get; set; }
        [ForeignKey("IdRoom")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdRoom { get; set; }
        public bool deleted = false;

        public DateTime RegistrationDate { get; set; }
    }
}
