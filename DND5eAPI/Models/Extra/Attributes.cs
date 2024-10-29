using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models.Extra
{
    [NotMapped]
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

        public static bool Exists(string name)
        {
            List<string> list = ["strength", "dexterity", "constitution", "intelligence", "wisdom", "charisma"];
            if (list.Contains(name.ToLower()))
            {
                return true;
            }
            return false;
        }

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
}
