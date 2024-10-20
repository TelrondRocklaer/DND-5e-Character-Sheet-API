﻿using DND5eAPI.Models.Structures.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Spells")]
    public class Spell
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public string Description { get; set; }
        public ICollection<Effect> Effects { get; set; }
        public int ConditionId { get; set; }
        public string SpellSlotLevel { get; set; }
        public string UpcastEffect { get; set; }
        public string Range { get; set; }
        public bool VerbalComponent { get; set; }
        public bool SomaticComponent { get; set; }
        public bool MaterialComponent { get; set; }
        public string MaterialComponentDescription { get; set; }
        public string Duration { get; set; }
        public string CastingTime { get; set; }
        public bool IsRitual { get; set; }
        public bool Concentration { get; set; }    
        public bool IsRecurring { get; set; } // Do you need to make saving throws every round?
        public string School { get; set; }

        //
        [ForeignKey("ConditionId")]
        public Condition Condition { get; set; }
        public ICollection<Class> Classes { get; set; }
        [JsonIgnore]
        public ICollection<Weapon> Weapons { get; set; }
        [JsonIgnore]
        public ICollection<Armor> Armors { get; set; }
    }
}
