using System.Text.Json.Serialization;

namespace DND5eAPI.Models.Extra.Effects
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(ResistanceEffect), "ResistanceEffect")]
    [JsonDerivedType(typeof(AttributeEffect), "AttributeEffect")]
    [JsonDerivedType(typeof(SkillEffect), "SkillEffect")]
    [JsonDerivedType(typeof(ArmorClassEffect), "ArmorClassEffect")]
    [JsonDerivedType(typeof(AttackRollEffect), "AttackRollEffect")]
    [JsonDerivedType(typeof(AbilityCheckEffect), "AbilityCheckEffect")]
    [JsonDerivedType(typeof(OtherCharacterEffect), "OtherCharacterEffect")]
    [JsonDerivedType(typeof(SpellAttackEffect), "SpellAttackEffect")]
    [JsonDerivedType(typeof(SpellHealingEffect), "SpellHealingEffect")]
    [JsonDerivedType(typeof(ConditionEffect), "ConditionEffect")]
    [JsonDerivedType(typeof(ActionEconomyEffect), "ActionEconomyEffect")]
    [JsonDerivedType(typeof(EsotericEffect), "EsotericEffect")]
    [JsonDerivedType(typeof(ExtraWeaponDamageEffect), "ExtraWeaponDamageEffect")]
    [JsonDerivedType(typeof(SpellCostEffect), "SpellCostEffect")]
    public abstract class Effect 
    { 
        public Effect() { }
    }
}
