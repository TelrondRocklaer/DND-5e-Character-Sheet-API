﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Races")]
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int BaseMovementSpeed { get; set; }

        //
        public List<Trait> Traits { get; set; }
        public List<Language> Languages { get; set; }
    }
}
