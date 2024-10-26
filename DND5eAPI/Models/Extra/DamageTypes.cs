namespace DND5eAPI.Models.Extra
{
    public sealed class DamageTypes
    {
        public class DamageType
        {
            public string Name { get; set; }
            public bool IsVulnerable { get; set; }
            public bool IsResistant { get; set; }
            public bool IsImmune { get; set; }

            internal DamageType(string name) => Name = name;
        }

        public DamageType Bludgeoning = new("Bludgeoning");
        public DamageType Piercing = new("Piercing");
        public DamageType Slashing = new("Slashing");
        public DamageType Fire = new("Fire");
        public DamageType Cold = new("Cold");
        public DamageType Poison = new("Poison");
        public DamageType Acid = new("Acid");
        public DamageType Lightning = new("Lightning");
        public DamageType Thunder = new("Thunder");
        public DamageType Psychic = new("Psychic");
        public DamageType Necrotic = new("Necrotic");
        public DamageType Radiant = new ("Radiant");
        public DamageType Force = new("Force");
    }
}
