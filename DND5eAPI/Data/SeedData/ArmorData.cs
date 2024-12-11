using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class ArmorData
    {
        public static readonly Armor WizardsRobes = new()
        {
            Id = 1,
            Name = "Wizards Robes",
            IndexName = "wizards-robes",
            Description = "A Robe has vocational or ceremonial significance. Some events and locations admit only people wearing a Robe bearing certain colors or symbols.",
            Cost = 1,
            Weight = 4,
            BaseArmorClass = 10,
            ArmorTypeId = 1
        };
    }
}
