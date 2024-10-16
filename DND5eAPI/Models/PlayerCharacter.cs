using System.Text.Json.Serialization;

namespace DND5eAPI.Models
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
                public bool HasAdvantage { get; set; } = false;
                public bool HasDisadvantage { get; set; } = false;
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
    }

    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public int MovementSpeed { get; set; }
        public bool WearsArmor { get; set; }
        public bool IsShieldEquipped { get; set; }
        public Attributes Attributes { get; set; }
        public Resistances Resistances { get; set; }
        public bool HasAdvantageOnConcentrationSavingThrows { get; set; }
        public bool HasDisadvantageOnConcentrationSavingThrows { get; set; }

        public int ProficiencyBonus
        {
            get
            {
                return 1 + (int)Math.Ceiling((double)(Level / 4));
            }
        }

        public int PassivePerception
        {
            get
            {
                return 10 + Attributes["wisdom"].Modifier + (Attributes["wisdom"]["perception"].IsProficient ? ProficiencyBonus : 0);
            }
        }

        //
        public Race Race { get; set; }
        public Class Class { get; set; }
        public Background Background { get; set; }
        public List<Feat> Feats { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Tool> ToolProficiencies { get; set; }
        public List<Equipment> Inventory { get; set; }
        public List<Armor> EquipedArmor { get; set; }
        public List<Weapon> EquipedWeapons { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}
