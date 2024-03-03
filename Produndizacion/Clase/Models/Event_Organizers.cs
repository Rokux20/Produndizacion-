using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class Event_Organizers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdOrganizer { get; set; } 
        public string  FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public string  Phone { get; set;}

        public List<EventOrganizerAssociation> eventOrganizerAssociation { get; set; }


    }
}
