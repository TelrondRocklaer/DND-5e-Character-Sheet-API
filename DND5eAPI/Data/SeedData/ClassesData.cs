using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Proficiencies;

namespace DND5eAPI.Data.SeedData
{
    public static class ClassesData
    {
        public static readonly Class Barbarian = new()
        {
            Id = 1,
            Name = "Barbarian",
            PrimaryAbility = "Strength",
            HitDie = "d12",
            SpecialPointsName = "Rage",
            NumberOfSkillsToChoose = 2,
            SkillProficiencyOptions = ["Animal Handling", "Athletics", "Intimidation", "Nature", "Perception", "Survival"],
            StartingGold = 15,
            Proficiencies = 
            [
                new ArmorProficiency("Light"),
                new ArmorProficiency("Medium"),
                new ArmorProficiency("Shield"),
                new ProficiencyGroup("Simple Weapons"),
                new ProficiencyGroup("Martial Weapons"),
                new SavingThrowProficiency("Strength"),
                new SavingThrowProficiency("Constitution"),
            ]
        };

        public static Class[] Classes =
        [
            Barbarian
        ];
    }
}
