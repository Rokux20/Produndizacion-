using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class EventOrganizerAssociation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEventOrg { get; set; }


        public int IdEvents { get; set; }   
        public Events events { get; set; } /// llave foranea 
        public int IdOrganizer { get; set; }
        public Event_Organizers event_Organizers { get; set; } /// llave foranea 



    }
}
