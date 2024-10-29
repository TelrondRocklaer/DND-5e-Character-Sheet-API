using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models.Extra
{
    [NotMapped]
    public static class DamageTypes
    {
        public class DamageType
        {
            public string Name { get; set; }
            public bool IsVulnerable { get; set; }
            public bool IsResistant { get; set; }
            public bool IsImmune { get; set; }

            internal DamageType(string name) => Name = name;
        }

        public static DamageType Bludgeoning = new("Bludgeoning");
        public static DamageType Piercing = new("Piercing");
        public static DamageType Slashing = new("Slashing");
        public static DamageType Fire = new("Fire");
        public static DamageType Cold = new("Cold");
        public static DamageType Poison = new("Poison");
        public static DamageType Acid = new("Acid");
        public static DamageType Lightning = new("Lightning");
        public static DamageType Thunder = new("Thunder");
        public static DamageType Psychic = new("Psychic");
        public static DamageType Necrotic = new("Necrotic");
        public static DamageType Radiant = new ("Radiant");
        public static DamageType Force = new("Force");

        public static bool Exists(string name)
        {
            List<string> list = ["bludgeoning", "piercing", "slashing", "fire", "cold", "poison", "acid", "lightning", "thunder", "psychic", "necrotic", "radiant", "force"];
            if (list.Contains(name.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static DamageType GetDamageType(string name) => name.ToLower() switch
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
            _ => throw new ArgumentException("Invalid damage type")
        };

        public static List<DamageType> GetDamageTypes => [
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
