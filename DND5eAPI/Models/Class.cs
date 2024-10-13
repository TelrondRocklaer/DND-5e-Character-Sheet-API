using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryAbility { get; set; }
        public string HitDie { get; set; }
        public string SavingThrowProficiencies { get; set; }
        public string SkillProficiencyOptions { get; set; }
        public int StartingGold { get; set; }

        //
        public List<ArmorType> ArmorProficiencies { get; set; }
        public List<WeaponType> WeaponProficiencies { get; set; }
        public List<Tool> ToolProficiencies { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Spell> Spells { get; set; }
    }
}
