using DND5eAPI.Models.Extra.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Weapons")]
    public class Weapon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public string Description { get; set; }
        public int MagicBonus { get; set; }
        public int WeaponTypeId { get; set; }
        public double Weight { get; set; }
        public ICollection<Effect>? Effects { get; set; }
        public int? AppliedConditionId { get; set; }
        public bool AttunementRequired { get; set; }

        //
        [ForeignKey("AppliedConditionId")]
        public Condition Condition { get; set; }
        public WeaponType WeaponType { get; set; }
        public ICollection<Trait> Traits { get; set; }
        public ICollection<Spell> Spells { get; set; }
    }
}
