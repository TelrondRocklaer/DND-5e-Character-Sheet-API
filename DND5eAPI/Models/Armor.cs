using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string ArmorClass { get; set; }
        public int ArmorTypeId { get; set; }
        public string EffectString { get; set; }

        //
        [ForeignKey("ArmorTypeId")]
        public ArmorType ArmorType { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Spell> Spells { get; set; }
    }
}
