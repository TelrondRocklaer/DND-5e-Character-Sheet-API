using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Subclasses")]
    public class Subclass
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        [JsonIgnore]
        public ICollection<Trait> Traits { get; set; }
        [JsonIgnore]
        public ICollection<Spell> Spells { get; set; }
    }
}
