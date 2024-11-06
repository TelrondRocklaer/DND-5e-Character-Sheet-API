using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Effects;

namespace DND5eAPI.Data.SeedData
{
    public static class ConditionsData
    {
        public static readonly Condition Blinded = new()
        {
            Id = 1,
            Name = "Blinded",
            Description = "While you have the Blinded condition, you experience the following effects. Can’t See. You can’t see and automatically fail any ability check that requires sight. Attacks Affected. Attack rolls against you have Advantage, and your attack rolls have Disadvantage.",
            Effects = [new EsotericEffect("Can't see", "You can’t see and automatically fail any ability check that requires sight"), 
                       new AttackRollEffect(hasAdvantageOrDisadvantage: false, attackersHaveAdvantageOrDisadvantage: true)]
        };

        public static readonly Condition Charmed = new()
        {
            Id = 2,
            Name = "Charmed",
            Description = "While you have the Charmed condition, you experience the following effects. Can’t Harm the Charmer. You can’t attack the charmer or target the charmer with damaging abilities or magical effects. Social Advantage. The charmer has Advantage on any ability check to interact with you socially.",
            Effects = [new EsotericEffect("Can't harm the charmer", "You can’t attack the charmer or target the charmer with damaging abilities or magical effects"), 
                       new EsotericEffect("Social advantage", "The charmer has Advantage on any ability check to interact with you socially")]
        }; 

        public static readonly Condition Deafened = new()
        {
            Id = 3,
            Name = "Deafened",
            Description = "While you have the Deafened condition, you experience the following effect. Can’t Hear. You can’t hear and automatically fail any ability check that requires hearing.",
            Effects = [new EsotericEffect("Can't hear", "You can’t hear and automatically fail any ability check that requires hearing")]
        };

        public static readonly Condition Exhaustion = new()
        {
            Id = 4,
            Name = "Exhaustion",
            Description = "While you have the Exhaustion condition, you experience the following effects. Exhaustion Levels. This condition is cumulative. Each time you receive it, you gain 1 Exhaustion level. You die if your Exhaustion level is 6. D20 Tests Affected. When you make a D20 Test, the roll is reduced by 2 times your Exhaustion level. Speed Reduced. Your Speed is reduced by a number of feet equal to 5 times your Exhaustion level. Removing Exhaustion Levels. Finishing a Long Rest removes 1 of your Exhaustion levels. When your Exhaustion level reaches 0, the condition ends.",
            Effects = [new EsotericEffect("Exhaustion levels", "This condition is cumulative. Each time you receive it, you gain 1 Exhaustion level. You die if your Exhaustion level is 6"), 
                       new EsotericEffect("D20 tests affected", "When you make a D20 Test, the roll is reduced by 2 times your Exhaustion level"), 
                       new OtherCharacterEffect(movementSpeedModifier: 0), 
                       new EsotericEffect("Removing Exhaustion Levels", "Finishing a Long Rest removes 1 of your Exhaustion levels. When your Exhaustion level reaches 0, the condition ends")]
        };

        public static readonly Condition Frightened = new()
        {
            Id = 5,
            Name = "Frightened",
            Description = "While you have the Frightened condition, you experience the following effects. Ability Checks and Attacks Affected. You have Disadvantage on ability checks and attack rolls while the source of fear is within line of sight. Can’t Approach. You can’t willingly move closer to the source of fear.",
            Effects = [new AbilityCheckEffect(hasAdvantageOrDisadvantage: false),
                       new AttackRollEffect(hasAdvantageOrDisadvantage: false),
                       new EsotericEffect("Can't approach", "You can’t willingly move closer to the source of fear")]
        };

        public static readonly Condition Grappled = new()
        {
            Id = 6,
            Name = "Grappled",
            Description = "While you have the Grappled condition, you experience the following effects. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. You have Disadvantage on attack rolls against any target other than the grappler. Movable. The grappler can drag or carry you when it moves, but every foot of movement costs it 1 extra foot unless you are Tiny or two or more sizes smaller than it.",
            Effects = [new OtherCharacterEffect(movementSpeedModifier: 0),
                       new EsotericEffect("Attacks Affected", "You have Disadvantage on attack rolls against any target other than the grappler."),
                       new EsotericEffect("Movable", "The grappler can drag or carry you when it moves, but every foot of movement costs it 1 extra foot unless you are Tiny or two or more sizes smaller than it")]
        };

        public static readonly Condition Incapacitated = new()
        {
            Id = 7,
            Name = "Incapacitated",
            Description = "While you have the Incapacitated condition, you experience the following effects. Inactive. You can’t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can’t speak. Surprised. If you’re Incapacitated when you roll Initiative, you have Disadvantage on the roll.",
            Effects = [new ActionEconomyEffect(0, 0, 0),
                       new EsotericEffect("No Concentration", "Your Concentration is broken."),
                       new EsotericEffect("Speechless", "You can’t speak."),
                       new EsotericEffect("Surprised", "If you’re Incapacitated when you roll Initiative, you have Disadvantage on the roll.")]
        };

        public static readonly Condition Invisible = new()
        {
            Id = 8,
            Name = "Invisible",
            Description = "While you have the Invisible condition, you experience the following effects. Surprise. If you’re Invisible when you roll Initiative, you have Advantage on the roll. Concealed. You aren’t affected by any effect that requires its target to be seen unless the effect’s creator can somehow see you. Any equipment you are wearing or carrying is also concealed. Attacks Affected. Attack rolls against you have Disadvantage, and your attack rolls have Advantage. If a creature can somehow see you, you don’t gain this benefit against that creature.",
            Effects = [new EsotericEffect("Surprise", "If you’re Invisible when you roll Initiative, you have Advantage on the roll."),
                       new EsotericEffect("Concealed", "You aren’t affected by any effect that requires its target to be seen unless the effect’s creator can somehow see you. Any equipment you are wearing or carrying is also concealed."),
                       new AttackRollEffect(hasAdvantageOrDisadvantage: true, attackersHaveAdvantageOrDisadvantage: false)]
        };

        public static readonly Condition Paralyzed = new()
        {
            Id = 9,
            Name = "Paralyzed",
            Description = "While you have the Paralyzed condition, you experience the following effects. Incapacitated. You have the Incapacitated condition. Speed 0. Your Speed is 0 and can’t increase. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Attacks Affected. Attack rolls against you have Advantage. Automatic Critical Hits. Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you",
            Effects = [new ConditionEffect(Incapacitated),
                       new OtherCharacterEffect(movementSpeedModifier: 0),
                       new AttributeEffect("strength", automaticallySucceedsOnSavingThrows: false),
                       new AttributeEffect("dexterity", automaticallySucceedsOnSavingThrows: false),
                       new AttackRollEffect(attackersHaveAdvantageOrDisadvantage: true),
                       new EsotericEffect("Automatic Critical Hits", "Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.")]
        };

        public static readonly Condition Petrified = new()
        {
            Id = 10,
            Name = "Petrified",
            Description = "While you have the Petrified condition, you experience the following effects. Turned to Inanimate Substance. You are transformed, along with any nonmagical objects you are wearing and carrying, into a solid inanimate substance (usually stone). Your weight increases by a factor of ten, and you cease aging. Incapacitated. You have the Incapacitated condition. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Resist Damage. You have Resistance to all damage. Poison Immunity. You have Immunity to the Poisoned condition.",
            Effects = [new EsotericEffect("Turned to Inanimate Substance", "You are transformed, along with any nonmagical objects you are wearing and carrying, into a solid inanimate substance (usually stone). Your weight increases by a factor of ten, and you cease aging."),
                       new ConditionEffect(Incapacitated),
                       new OtherCharacterEffect(movementSpeedModifier: 0),
                       new AttackRollEffect(attackersHaveAdvantageOrDisadvantage: true),
                       new AttributeEffect("strength", automaticallySucceedsOnSavingThrows: false),
                       new AttributeEffect("dexterity", automaticallySucceedsOnSavingThrows: false),
                       new EsotericEffect("Resist Damage", "You have Resistance to all damage."),
                       new EsotericEffect("Poison Immunity", "You have Immunity to the Poisoned condition.")]
        };

        public static readonly Condition Poisoned = new()
        {
            Id = 11,
            Name = "Poisoned",
            Description = "While you have the Poisoned condition, you experience the following effect. Ability Checks and Attacks Affected. You have Disadvantage on attack rolls and ability checks.",
            Effects = [new AttackRollEffect(hasAdvantageOrDisadvantage: false), 
                       new AbilityCheckEffect(hasAdvantageOrDisadvantage: false)]
        };

        public static readonly Condition Prone = new()
        {
            Id = 12,
            Name = "Prone",
            Description = "While you have the Prone condition, you experience the following effects. Restricted Movement. Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can’t right yourself. Attacks Affected. You have Disadvantage on attack rolls. An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.",
            Effects = [new EsotericEffect("Restricted Movement", "Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can’t right yourself."),
                       new AttackRollEffect(hasAdvantageOrDisadvantage: false),
                       new EsotericEffect("Attacks Affected", "An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.")]
        };

        public static readonly Condition Restrained = new()
        {
            Id = 13,
            Name = "Restrained",
            Description = "While you have the Restrained condition, you experience the following effects. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage, and your attack rolls have Disadvantage. Saving Throws Affected. You have Disadvantage on Dexterity saving throws.",
            Effects = [new OtherCharacterEffect(movementSpeedModifier: 0),
                       new AttackRollEffect(hasAdvantageOrDisadvantage: false, attackersHaveAdvantageOrDisadvantage: true),
                       new AttributeEffect("dexterity", hasAdvantageOrDisadvantageOnSavingThrows: false)]
        };

        public static readonly Condition Stunned = new()
        {
            Id = 14,
            Name = "Stunned",
            Description = "While you have the Stunned condition, you experience the following effects. Incapacitated. You have the Incapacitated condition. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Attacks Affected. Attack rolls against you have Advantage.",
            Effects = [new ConditionEffect(Incapacitated),
                       new AttributeEffect("strength", automaticallySucceedsOnSavingThrows: false),
                       new AttributeEffect("dexterity", automaticallySucceedsOnSavingThrows: false),
                       new AttackRollEffect(attackersHaveAdvantageOrDisadvantage: true)]
        };

        public static readonly Condition Unconscious = new()
        {
            Id = 15,
            Name = "Unconscious",
            Description = "While you have the Unconscious condition, you experience the following effects. Inert. You have the Incapacitated and Prone conditions, and you drop whatever you’re holding. When this condition ends, you remain Prone. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Automatic Critical Hits. Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you. Unaware. You’re unaware of your surroundings.",
            Effects = [new ConditionEffect(Incapacitated),
                       new ConditionEffect(Prone),
                       new OtherCharacterEffect(movementSpeedModifier: 0),
                       new AttackRollEffect(attackersHaveAdvantageOrDisadvantage: true),
                       new AttributeEffect("strength", automaticallySucceedsOnSavingThrows: false),
                       new AttributeEffect("dexterity", automaticallySucceedsOnSavingThrows: false),
                       new EsotericEffect("Automatic Critical Hits", "Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you."),
                       new EsotericEffect("Unaware", "You’re unaware of your surroundings.")]
        };

        public static Condition[] Conditions = [
            Blinded,
            Charmed,
            Deafened,
            Exhaustion,
            Frightened,
            Grappled,
            Incapacitated,
            Invisible,
            Paralyzed,
            Petrified,
            Poisoned,
            Prone,
            Restrained,
            Stunned,
            Unconscious
        ];
    }
}
