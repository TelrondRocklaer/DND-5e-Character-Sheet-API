using System.Text.Json.Serialization;

namespace DND5eAPI.Models.Extra
{
    public class Attributes
    {
        public class Attribute
        {
            public string? Name { get; set; }
            public int Value { get; set; }

            [JsonIgnore]
            public List<Skill> Skills { get; set; }

            public Attribute() { }

            public Attribute(string name, List<string> skills)
            {
                Name = name;
                Skills = skills.Select(name => new Skill(name)).ToList();
            }

            public class Skill
            {
                public string Name { get; set; }

                public Skill() { }

                public Skill(string name) => Name = name;
            }

            public Skill this[string name] => Skills.FirstOrDefault(skill => skill.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)) ?? throw new ArgumentException($"Invalid skill name: {name}");
        }

        public Attribute Strength { get; set; } = new("Strength", ["Athletics"]);
        public Attribute Dexterity { get; set; } = new("Dexterity", ["Acrobatics", "Sleight of Hand", "Stealth"]);
        public Attribute Constitution { get; set; } = new("Constitution", []);
        public Attribute Intelligence { get; set; } = new("Intelligence", ["Arcana", "History", "Investigation", "Nature", "Religion"]);
        public Attribute Wisdom { get; set; } = new("Wisdom", ["Animal Handling", "Insight", "Medicine", "Perception", "Survival"]);
        public Attribute Charisma { get; set; } = new("Charisma", ["Deception", "Intimidation", "Performance", "Persuasion"]);

        public Attributes() { }

        public Attributes(int strength = 10, int dexterity = 10, int constitution = 10, int intelligence = 10, int wisdom = 10, int charisma = 10)
        {
            Strength.Value = strength;
            Dexterity.Value = dexterity;
            Constitution.Value = constitution;
            Intelligence.Value = intelligence;
            Wisdom.Value = wisdom;
            Charisma.Value = charisma;
        }

        public static bool Exists(string name)
        {
            List<string> list = ["strength", "dexterity", "constitution", "intelligence", "wisdom", "charisma"];
            if (list.Contains(name.ToLower()))
            {
                return true;
            }
            return false;
        }

        public Attribute this[string name] => name.ToLower() switch
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
}
