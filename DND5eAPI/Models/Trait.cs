using DND5eAPI.Models.Extra.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Traits")]
    public class Trait
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public string Description { get; set; }
        public ICollection<Effect>? Effects { get; set; }
        public string Requirement { get; set; }

        //
        [JsonIgnore]
        public ICollection<Race> Races { get; set; }
        [JsonIgnore]
        public ICollection<Weapon> Weapons { get; set; }
        [JsonIgnore]
        public ICollection<Armor> Armors { get; set; }
        [JsonIgnore]
        public ICollection<Background> Backgrounds { get; set; }
        [JsonIgnore]
        public ICollection<Class> Classes { get; set; }
    }
}
