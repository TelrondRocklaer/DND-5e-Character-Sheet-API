using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class SubracesData
    {
        public static readonly Subrace Drow = new()
        {
            Id = 1,
            Name = "Drow",
            Description = "Drow typically dwell in the Underdark and have been shaped by it. Some drow individuals and societies avoid the Underdark altogether yet carry its magic. In the Eberron setting, for example, drow dwell in rainforests and cyclopean ruins on the continent of Xen’drik.",
            ParentRaceId = 2
        };

        public static readonly Subrace HighElf = new()
        {
            Id = 2,
            Name = "High Elf",
            Description = "High elves have been infused with the magic of crossings between the Feywild and the Material Plane. On some worlds, high elves refer to themselves by other names. For example, they call themselves sun or moon elves in the Forgotten Realms setting, Silvanesti and Qualinesti in the Dragonlance setting, and Aereni in the Eberron setting",
            ParentRaceId = 2
        };

        public static readonly Subrace WoodElf = new()
        {
            Id = 3,
            Name = "Wood Elf",
            Description = "Wood elves carry the magic of primeval forests within themselves. They are known by many other names, including wild elves, green elves, and forest elves. Grugach are reclusive wood elves of the Greyhawk setting, while the Kagonesti and the Tairnadal are wood elves of the Dragonlance and Eberron settings, respectively.",
            ParentRaceId = 2
        };

        public static Subrace[] Subraces = [
            Drow, 
            HighElf, 
            WoodElf
        ];
    }
}
