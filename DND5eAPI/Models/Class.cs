using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        //public ICollection<Effect> Effects { get; set; }
        public int NumberOfSkillsToChoose { get; set; }
        public ICollection<string> SkillProficiencyOptions { get; set; }
        public int StartingGold { get; set; }

        //
        public ICollection<ArmorType> ArmorProficiencies { get; set; }
        public ICollection<WeaponType> WeaponProficiencies { get; set; }
        public ICollection<Tool> ToolProficiencies { get; set; }
        [JsonIgnore]
        public ICollection<Trait> Traits { get; set; }
        [JsonIgnore]
        public ICollection<Spell> Spells { get; set; }
    }
}
