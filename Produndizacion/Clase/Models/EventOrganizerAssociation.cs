using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class EventOrganizerAssociation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEventOrg { get; set; }

        [ForeignKey("IdEvents")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdEvents { get; set; }

        [ForeignKey("IdOrganizer")]  // Añadir esta anotación para configurar la relación con Attendee
        public int IdOrganizer { get; set; }

        public bool deleted = false;




    }
}
