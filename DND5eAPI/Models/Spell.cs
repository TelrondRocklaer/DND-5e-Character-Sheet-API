﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string EffectString { get; set; }
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
        public string School { get; set; }
        
        //
        List<Class> Classes { get; set; }
        List<Weapon> Weapons { get; set; }
        List<Armor> Armors { get; set; }
    }
}