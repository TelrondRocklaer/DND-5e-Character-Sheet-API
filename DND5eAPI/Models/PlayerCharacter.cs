using DND5eAPI.Models.Extra;
using DND5eAPI.Models.Extra.Proficiencies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("PlayerCharacters")]
    public class PlayerCharacter
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHitPoints { get; set; }
        public int SpecialPoints { get; set; } // Ki, Sorcery Points, etc.
        public List<SpellSlotDataNode>? SpellSlots { get; set; }
        public Attributes Attributes { get; set; }
        public ICollection<Proficiency> Proficiencies { get; set; }
        public List<Note>? Notes { get; set; }

        //
        public int RaceId { get; set; }
        [ForeignKey("RaceId")]
        public Race Race { get; set; }

        public int? SubraceId { get; set; }
        [ForeignKey("SubraceId")]
        public Subrace? Subrace { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

        public int? SubclassId { get; set; }
        [ForeignKey("SubclassId")]
        public Subclass? Subclass { get; set; }

        public int BackgroundId { get; set; }
        [ForeignKey("BackgroundId")]
        public Background Background { get; set; }

        public ICollection<Feat>? Feats { get; set; }
        public ICollection<Equipment>? Inventory { get; set; }
        public ICollection<Armor>? EquipedArmor { get; set; }
        public ICollection<Weapon>? EquipedWeapons { get; set; }
        public ICollection<Spell>? Spells { get; set; }
        public ICollection<Language>? Languages { get; set; }
    }
}
