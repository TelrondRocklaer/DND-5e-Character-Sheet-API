using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Subraces")]
    public class Subrace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentRaceId { get; set; }
        //
        [ForeignKey("ParentRaceId")]
        public Race ParentRace { get; set; }
        public ICollection<Trait> Traits { get; set; }
    }
}
