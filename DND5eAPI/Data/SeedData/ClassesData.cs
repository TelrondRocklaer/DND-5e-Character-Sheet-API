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

        public static readonly Class Wizard = new()
        {
            Id = 2,
            Name = "Wizard",
            PrimaryAbility = "Intelligence",
            HitDie = "d6",
            SpecialPointsName = "Arcane Recovery",
            SkillProficiencyOptions = ["Arcana", "History", "Insight", "Investigation", "Medicine", "Nature", "Religion"],
            StartingGold = 5,
            Proficiencies =
            [
                new ProficiencyGroup("Simple Weapons"),
                new SavingThrowProficiency("Intelligence"),
                new SavingThrowProficiency("Wisdom"),
            ],
            StartingEquipment =
            [
                EquipmentData.Spellbook,
            ],
            Spells =
            [
                SpellsData.RayOfFrost,
                SpellsData.Firebolt,
                SpellsData.Fireball,
                SpellsData.ScorchingRay,
                SpellsData.HoldPerson
            ]
        };

        public static Class[] Classes =
        [
            Barbarian,
            Wizard
        ];
    }
}
