using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Effects;

namespace DND5eAPI.Data.SeedData
{
    public static class SpellsData
    {
        public static readonly Spell Fireball = new()
        {
            Name = "Fireball",
            IndexName = "fireball",
            Description = "A bright streak flashes from you to a point you choose within range and then blossoms with a low roar into a fiery explosion. Each creature in a 20-foot-radius Sphere centered on that point makes a Dexterity saving throw, taking 8d6 Fire damage on a failed save or half as much damage on a successful one. Flammable objects in the area that aren’t being worn or carried start burning.",
            CanTargetSelf = false,
            Effects = [new AttackingActionEffect("8d6", false, "fire", "dexterity", 15, "half-damage")],
            SpellSlotLevel = 3,
            UpcastEffect = "1d6",
            Range = "150 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = true,
            MaterialComponentDescription = "a ball of bat guano and sulfur",
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"
        };
    }
}
