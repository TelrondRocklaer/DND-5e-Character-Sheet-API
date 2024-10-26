using DND5eAPI.Models.Extra;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    public class PlayerCharacter
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public int MovementSpeed { get; set; }
        public int SpecialPoints { get; set; } // Ki, Sorcery Points, etc.
        public int CurrentSpecialPoints { get; set; }
        public List<SpellSlotDataNode> SpellSlots { get; set; }
        public bool WearsArmor { get; set; }
        public bool IsShieldEquipped { get; set; }
        public Attributes Attributes { get; set; }
        public Resistances Resistances { get; set; }
        public bool HasAdvantageOnConcentrationSavingThrows { get; set; }
        public bool HasDisadvantageOnConcentrationSavingThrows { get; set; }
        public bool IsConcentrating { get; set; }
        public bool IsThreataned { get; set; }

        [NotMapped]
        [JsonIgnore]
        public int ProficiencyBonus
        {
            get
            {
                return 1 + (int)Math.Ceiling((double)(Level / 4));
            }
        }

        [NotMapped]
        [JsonIgnore]
        public int PassivePerception
        {
            get
            {
                return 10 + Attributes["wisdom"].Modifier + (Attributes["wisdom"]["perception"].IsProficient ? ProficiencyBonus : 0);
            }
        }

        //
        public int RaceId { get; set; }
        [ForeignKey("RaceId")]
        public Race Race { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public int BackgroundId { get; set; }
        [ForeignKey("BackgroundId")]
        public Background Background { get; set; }

        public ICollection<Feat> Feats { get; set; }
        public ICollection<Trait> Traits { get; set; }
        public ICollection<Tool> ToolProficiencies { get; set; }
        public ICollection<Equipment> Inventory { get; set; }
        public ICollection<Armor> EquipedArmor { get; set; }
        public ICollection<Weapon> EquipedWeapons { get; set; }
        public ICollection<Spell> Spells { get; set; }
        public ICollection<Condition> Conditions { get; set; }
    }
}
