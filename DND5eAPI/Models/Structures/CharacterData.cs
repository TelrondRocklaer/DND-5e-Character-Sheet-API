using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models.Structures
{
    [NotMapped]
    public class CharacterData
    {
        public class Attributes()
        {
            public class Attribute(string name, List<string> skills)
            {
                public string? Name { get; set; } = name;
                public int Value { get; set; } = 10;
                public bool IsProficientInSavingThrows { get; set; } = false;
                public bool HasAdvantageOnSavingThrows { get; set; } = false;
                public bool HasAdvantageOnAbilityChecks { get; set; } = false;
                public bool HasDisadvantageOnSavingThrows { get; set; } = false;
                public bool HasDisadvantageOnAbilityChecks { get; set; } = false;
                public List<Skill> Skills { get; set; } = skills.Select(name => new Skill(name)).ToList();
                public class Skill(string name)
                {
                    public string Name { get; set; } = name;
                    public bool IsProficient { get; set; } = false;
                    public bool HasAdvantageOnChecks { get; set; } = false;
                    public bool HasDisadvantageOnChecks { get; set; } = false;
                }
                public int Modifier => (Value - 10) / 2;
                public Skill this[string name] => Skills.FirstOrDefault(skill => skill.Name == name) ?? throw new ArgumentException($"Invalid skill name: {name}");
            }

            Attribute Strength = new("Strength", ["Athletics"]);
            Attribute Dexterity = new("Dexterity", ["Acrobatics", "Sleight of Hand", "Stealth"]);
            Attribute Constitution = new("Constitution", []);
            Attribute Intelligence = new("Intelligence", ["Arcana", "History", "Investigation", "Nature", "Religion"]);
            Attribute Wisdom = new("Wisdom", ["Animal Handling", "Insight", "Medicine", "Perception", "Survival"]);
            Attribute Charisma = new("Charisma", ["Deception", "Intimidation", "Performance", "Persuasion"]);

            public Attribute this[string name] => name switch
            {
                "strength" => Strength,
                "dexterity" => Dexterity,
                "constitution" => Constitution,
                "intelligence" => Intelligence,
                "wisdom" => Wisdom,
                "charisma" => Charisma,
                _ => throw new ArgumentException($"Invalid attribute name: {name}")
            };

            public List<Attribute> GetAttributes =>
            [
                Strength,
                Dexterity,
                Constitution,
                Intelligence,
                Wisdom,
                Charisma
            ];
        }

        public class Resistances
        {
            public class DamageType
            {
                public string Name { get; set; }
                public bool IsVulnerable { get; set; }
                public bool IsResistant { get; set; }
                public bool IsImmune { get; set; }
            }

            DamageType Bludgeoning = new() { Name = "Bludgeoning" };
            DamageType Piercing = new() { Name = "Piercing" };
            DamageType Slashing = new() { Name = "Slashing" };
            DamageType Fire = new() { Name = "Fire" };
            DamageType Cold = new() { Name = "Cold" };
            DamageType Poison = new() { Name = "Poison" };
            DamageType Acid = new() { Name = "Acid" };
            DamageType Lightning = new() { Name = "Lightning" };
            DamageType Thunder = new() { Name = "Thunder" };
            DamageType Psychic = new() { Name = "Psychic" };
            DamageType Necrotic = new() { Name = "Necrotic" };
            DamageType Radiant = new() { Name = "Radiant" };
            DamageType Force = new() { Name = "Force" };

            public DamageType this[string name] => name switch
            {
                "bludgeoning" => Bludgeoning,
                "piercing" => Piercing,
                "slashing" => Slashing,
                "fire" => Fire,
                "cold" => Cold,
                "poison" => Poison,
                "acid" => Acid,
                "lightning" => Lightning,
                "thunder" => Thunder,
                "psychic" => Psychic,
                "necrotic" => Necrotic,
                "radiant" => Radiant,
                "force" => Force,
                _ => throw new ArgumentException($"Invalid damage type name: {name}")
            };

            public List<DamageType> GetTypes =>
            [
                Bludgeoning,
                Piercing,
                Slashing,
                Fire,
                Cold,
                Poison,
                Acid,
                Lightning,
                Thunder,
                Psychic,
                Necrotic,
                Radiant,
                Force
            ];
        }
    }
}
