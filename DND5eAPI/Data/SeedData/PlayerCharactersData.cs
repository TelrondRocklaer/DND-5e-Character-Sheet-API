using DND5eAPI.Models;
using DND5eAPI.Models.Extra;

namespace DND5eAPI.Data.SeedData
{
    public static class PlayerCharactersData
    {
        public static readonly PlayerCharacter Aria = new()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Aria",
            Level = 1,
            MaxHitPoints = 10,
            SpecialPoints = 1,
            SpellSlots = [],
            Attributes = new Attributes(),
            RaceId = 2,
            SubraceId = 2,
            ClassId = 1,
            BackgroundId = 1,
            Proficiencies = [],
            Notes = []
        };

        public static PlayerCharacter[] PlayerCharacters =
        [
            Aria
        ];
    }
}
