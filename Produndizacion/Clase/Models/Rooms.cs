using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase.Models
{
    public class Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   

        public int IdRoom { get; set; }
        public string  Name { get; set; }
        public int MaxCapacity { get; set; }

        public List<RoomAttendeeRegistration> roomAttendeeRegistration { get; set; }

    }
}
