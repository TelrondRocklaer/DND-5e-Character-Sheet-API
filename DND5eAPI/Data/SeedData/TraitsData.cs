using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Effects;

namespace DND5eAPI.Data.SeedData
{
    public static class TraitsData
    {
        public static readonly Trait UnarmoredDefense = new()
        {
            Id = 1,
            Name = "Unarmored Defense",
            IndexName = "unarmored-defense",
            Description = "While you are not wearing any armor, your Armor Class equals 10 + your Dexterity modifier + your Constitution modifier. You can use a shield and still gain this benefit.",
            Effects = [new ArmorClassEffect(false, "Constitution")],
            Requirement = "wearsArmor=false",
            UnlockLevel = 1
        };

        public static Trait[] Traits =
        [
            UnarmoredDefense
        ];
    }
}
