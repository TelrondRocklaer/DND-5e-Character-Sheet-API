using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Effects;

namespace DND5eAPI.Data.SeedData
{
    public static class SpellsData
    {
        public static readonly Spell EldritchBlast = new()
        {
            Id = 1,
            Name = "Eldritch Blast",
            IndexName = "eldritch-blast",
            Description = "You hurl a beam of crackling energy. Make a ranged spell attack against one creature or object in range. On a hit, the target takes 1d10 Force damage. Cantrip Upgrade. The spell creates two beams at level 5, three beams at level 11, and four beams at level 17. You can direct the beams at the same target or at different ones. Make a separate attack roll for each beam",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect("1d10", true, "force"), new SpellCostEffect(action: true)],
            SpellSlotLevel = 0,
            UpcastEffect = null,
            UpgradeLevels = [5, 11, 17],
            BaseNumberOfCasts = 1,
            Range = "120 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = false,
            MaterialComponentDescription = null,
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"
        };

        public static readonly Spell HealingWord = new()
        {
            Id = 2,
            Name = "Healing Word",
            IndexName = "healing-word",
            Description = "A creature of your choice that you can see within range regains Hit Points equal to 2d4 plus your spellcasting ability modifier. Using a Higher-Level Spell Slot. The healing increases by 2d4 for each spell slot level above 1",
            CanTargetSelf = true,
            Effects = [new SpellHealingEffect("2d4+{sam}", isTempHP: false), new SpellCostEffect(bonusAction: true)], // sam - spellcasting ability modifier
            SpellSlotLevel = 1,
            UpcastEffect = "2d4",
            UpgradeLevels = null,
            BaseNumberOfCasts = 1,
            Range = "60 feet",
            VerbalComponent = true,
            SomaticComponent = false,
            MaterialComponent = false,
            MaterialComponentDescription = null,
            Duration = "Instantaneous",
            CastingTime = "1 bonus action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Abjuration"
        };

        public static readonly Spell HoldPerson = new()
        {
            Id = 3,
            Name = "Hold Person",
            IndexName = "hold-person",
            Description = "Choose a Humanoid that you can see within range. The target must succeed on a Wisdom saving throw or have the Paralyzed condition for the duration. At the end of each of its turns, the target repeats the save, ending the spell on itself on a success. Using a Higher-Level Spell Slot. You can target one additional Humanoid for each spell slot level above 2.",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect(savingThrowAttribute: "Wisdom", savingThrowDC: -1, savingThrowSuccessEffect: "negate-effect"), 
                       new ConditionEffect(ConditionsData.Paralyzed), new SpellCostEffect(action: true)],
            SpellSlotLevel = 2,
            UpcastEffect = "bnoc+1", // bnoc - base number of casts
            UpgradeLevels = null,
            BaseNumberOfCasts = 1,
            Range = "60 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = true,
            MaterialComponentDescription = "a straight piece of iron",
            Duration = "Concentration, up to 1 minute",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = true,
            IsRecurring = true,
            IsRecurringOnMove = false,
            School = "Enchantment"
        };

        public static readonly Spell ScorchingRay = new()
        {
            Id = 4,
            Name = "Scorching Ray",
            IndexName = "scorching-ray",
            Description = "You hurl three fiery rays. You can hurl them at one target within range or at several. Make a ranged spell attack for each ray. On a hit, the target takes 2d6 Fire damage. Using a Higher-Level Spell Slot. You create one additional ray for each spell slot level above 2.",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect("2d6", true, "fire"), new SpellCostEffect(action: true)],
            SpellSlotLevel = 2,
            UpcastEffect = "bnoc+1", // bnof - base number of casts
            UpgradeLevels = null,
            BaseNumberOfCasts = 3,
            Range = "120 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = false,
            MaterialComponentDescription = null,
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"
        };

        public static readonly Spell Fireball = new()
        {
            Id = 5,
            Name = "Fireball",
            IndexName = "fireball",
            Description = "A bright streak flashes from you to a point you choose within range and then blossoms with a low roar into a fiery explosion. Each creature in a 20-foot-radius Sphere centered on that point makes a Dexterity saving throw, taking 8d6 Fire damage on a failed save or half as much damage on a successful one. Flammable objects in the area that aren’t being worn or carried start burning.",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect("8d6", false, "fire", "dexterity", 15, "half-damage"), new SpellCostEffect(action: true)],
            SpellSlotLevel = 3,
            UpcastEffect = "1d6",
            UpgradeLevels = null,
            BaseNumberOfCasts = 1,
            Range = "150 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = true,
            MaterialComponentDescription = "a ball of bat guano and sulfur",
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"
        };

        public static readonly Spell RayOfFrost = new()
        {
            Id = 6,
            Name = "Ray of Frost",
            IndexName = "ray-of-frost",
            Description = "A frigid beam of blue-white light streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, it takes 1d8 Cold damage, and its Speed is reduced by 10 feet until the start of your next turn.",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect("1d8", true, "cold"), new SpellCostEffect(action: true)],
            SpellSlotLevel = 0,
            UpcastEffect = null,
            UpgradeLevels = [5, 11, 17],
            BaseNumberOfCasts = 1,
            Range = "60 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = false,
            MaterialComponentDescription = null,
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"    
        };

        public static readonly Spell Firebolt = new()
        {
            Id = 7,
            Name = "Fire bolt",
            IndexName = "fire-bolt",
            Description = "You hurl a mote of fire at a creature or an object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 Fire damage. A flammable object hit by this spell starts burning if it isn’t being worn or carried.",
            CanTargetSelf = false,
            Effects = [new SpellAttackEffect("1d10", true, "fire"), new SpellCostEffect(action: true)],
            SpellSlotLevel = 0,
            UpcastEffect = null,
            UpgradeLevels = [5, 11, 17],
            BaseNumberOfCasts = 1,
            Range = "120 feet",
            VerbalComponent = true,
            SomaticComponent = true,
            MaterialComponent = false,
            MaterialComponentDescription = null,
            Duration = "Instantaneous",
            CastingTime = "1 action",
            IsRitual = false,
            Cooldown = "None",
            Concentration = false,
            IsRecurring = false,
            IsRecurringOnMove = false,
            School = "Evocation"
        };


        public static Spell[] Spells = [
            EldritchBlast, 
            HealingWord, 
            HoldPerson,
            ScorchingRay,
            Fireball,
            RayOfFrost,
            Firebolt
        ];
    }
}
