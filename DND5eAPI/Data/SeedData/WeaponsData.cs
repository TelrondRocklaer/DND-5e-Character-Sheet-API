using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class WeaponsData
    {
        public static readonly Weapon BasicQuarterstaff = new()
        {
            Id = 1,
            Name = "Quarterstaff",
            IndexName = "quarterstaff",
            Description = "A simple wooden staff, often used by mages.",
            MagicBonus = 0,
            WeaponTypeId = 8,
            Cost = 2,
            Weight = 4,
            AttunementRequired = false
        };

        public static Weapon[] Weapons = [BasicQuarterstaff];
    }
}
