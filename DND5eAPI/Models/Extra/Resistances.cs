using System.ComponentModel.DataAnnotations.Schema;
using static DND5eAPI.Models.Extra.DamageTypes;

namespace DND5eAPI.Models.Extra
{
    [NotMapped]
    public class Resistances
    {
        DamageTypes damageTypes = new();
        public DamageType this[string name] => name switch
        {
            "bludgeoning" => damageTypes.Bludgeoning,
            "piercing" => damageTypes.Piercing,
            "slashing" => damageTypes.Slashing,
            "fire" => damageTypes.Fire,
            "cold" => damageTypes.Cold,
            "poison" => damageTypes.Poison,
            "acid" => damageTypes.Acid,
            "lightning" => damageTypes.Lightning,
            "thunder" => damageTypes.Thunder,
            "psychic" => damageTypes.Psychic,
            "necrotic" => damageTypes.Necrotic,
            "radiant" => damageTypes.Radiant,
            "force" => damageTypes.Force,
            _ => throw new ArgumentException($"Invalid damage type name: {name}")
        };

        public List<DamageType> GetTypes =>
        [
            damageTypes.Bludgeoning,
            damageTypes.Piercing,
            damageTypes.Slashing,
            damageTypes.Fire,
            damageTypes.Cold,
            damageTypes.Poison,
            damageTypes.Acid,
            damageTypes.Lightning,
            damageTypes.Thunder,
            damageTypes.Psychic,
            damageTypes.Necrotic,
            damageTypes.Radiant,
            damageTypes.Force
        ];
    }
}