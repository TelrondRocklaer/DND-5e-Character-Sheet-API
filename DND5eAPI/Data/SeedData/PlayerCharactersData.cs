using DND5eAPI.Models;
using DND5eAPI.Models.Extra;
using DND5eAPI.Models.Extra.Proficiencies;

namespace DND5eAPI.Data.SeedData
{
    public static class PlayerCharactersData
    {
        public static readonly PlayerCharacter Gale = new()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Gale",
            Level = 1,
            MaxHitPoints = 8,
            SpecialPoints = 0,
            SpellSlots = [new SpellSlotDataNode(1, 2)],
            Attributes = new Attributes(9, 14, 15, 16, 11, 13),
            RaceId = 4,
            ClassId = 2,
            BackgroundId = 2,
            Proficiencies = [new SkillProficiency("intelligence", "arcana"), new SkillProficiency("intelligence", "history"), new SkillProficiency("wisdom", "insight"), new SkillProficiency("intelligence", "investigation")],
            Spells = [SpellsData.Firebolt, SpellsData.RayOfFrost, SpellsData.HoldPerson],
            EquipedArmor = [ArmorData.WizardsRobes],
            EquipedWeapons = [WeaponsData.BasicQuarterstaff],
            Notes = []
        };

        public static PlayerCharacter[] PlayerCharacters =
        [
            Gale
        ];
    }
}
