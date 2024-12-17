using DND5eAPI.Models.Extra.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Armors")]
    public class Armor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public double Weight { get; set; }
        public int BaseArmorClass { get; set; }
        public ICollection<Effect>? Effects { get; set; }
        public int ArmorTypeId { get; set; }

        //
        [ForeignKey("ArmorTypeId")]
        public ArmorType ArmorType { get; set; }
        public ICollection<Trait>? Traits { get; set; }
        public ICollection<Spell>? Spells { get; set; }
    }
}
