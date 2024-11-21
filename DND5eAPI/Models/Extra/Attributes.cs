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
            public List<Skill> Skills { get; set; } = skills.Select(name => new Skill(name)).ToList();
            public class Skill(string name)
            {
                public string Name { get; set; } = name;
            }
            public Skill this[string name] => Skills.FirstOrDefault(skill => skill.Name == name) ?? throw new ArgumentException($"Invalid skill name: {name}");
        }

        public Attribute Strength = new("Strength", ["Athletics"]);
        public Attribute Dexterity = new("Dexterity", ["Acrobatics", "Sleight of Hand", "Stealth"]);
        public Attribute Constitution = new("Constitution", []);
        public Attribute Intelligence = new("Intelligence", ["Arcana", "History", "Investigation", "Nature", "Religion"]);
        public Attribute Wisdom = new("Wisdom", ["Animal Handling", "Insight", "Medicine", "Perception", "Survival"]);
        public Attribute Charisma = new("Charisma", ["Deception", "Intimidation", "Performance", "Persuasion"]);

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
