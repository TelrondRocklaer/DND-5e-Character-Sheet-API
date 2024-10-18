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
        public int BaseArmorClass { get; set; }
        public string Resistances { get; set; }
        public string Effects { get; set; }
        public int ArmorTypeId { get; set; }

        //
        [ForeignKey("ArmorTypeId")]
        public ArmorType ArmorType { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Spell> Spells { get; set; }
    }
}
