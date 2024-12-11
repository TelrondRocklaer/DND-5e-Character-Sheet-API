using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class EquipmentData
    {
        public static readonly Equipment Spellbook = new()
        {
            Id = 1,
            Name = "Spellbook",
            IndexName = "spellbook",
            Cost = 50,
            Weight = 3,
            Description = "A book containing spells used by wizards.",
            EquipmentCategoryId = 5
        };

        public static readonly Equipment Parchment = new()
        {
            Id = 2,
            Name = "Parchment",
            IndexName = "parchment",
            Cost = 1,
            Weight = 0,
            Description = "One sheet of Parchment can hold about 250 handwritten words.",
            EquipmentCategoryId = 5
        };
    }
}
