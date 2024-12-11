using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Races")]
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string Size { get; set; }
        public int BaseMovementSpeed { get; set; }

        //
        public ICollection<Trait>? Traits { get; set; }
        public ICollection<Language>? Languages { get; set; }
    }
}
