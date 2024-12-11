using DND5eAPI.Models.Extra.Proficiencies;
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
        public string SpecialPointsName { get; set; }
        public List<string> SkillProficiencyOptions { get; set; }
        public int StartingGold { get; set; }
        public ICollection<Proficiency> Proficiencies { get; set; }

        //
        [JsonIgnore]
        public ICollection<Subclass>? Subclasses { get; set; }
        public ICollection<Equipment>? StartingEquipment { get; set; }
        public ICollection<Trait>? Traits { get; set; }
        [JsonIgnore]
        public ICollection<Spell>? Spells { get; set; }
    }
}
