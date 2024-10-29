using System.ComponentModel.DataAnnotations.Schema;
using static DND5eAPI.Models.Extra.DamageTypes;

namespace DND5eAPI.Models.Extra
{
    [NotMapped]
    public class Resistances
    {
        List<DamageType> Types = GetDamageTypes;
        public DamageType this[string name] => name.ToLower() switch
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
}