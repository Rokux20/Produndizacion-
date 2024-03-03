using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class Events
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   

        public int IdEvents { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int MaxCapacity { get; set; }

        public List<Event_Attendee_Registration> event_Attendee_Registration { get; set; }
        public List<EventOrganizerAssociation>  eventOrganizerAssociation { get; set; }


    }
}
