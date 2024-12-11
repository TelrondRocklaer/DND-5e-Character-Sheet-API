using System.Text.Json.Serialization;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(SkillProficiency), "SkillProficiency")]
    [JsonDerivedType(typeof(WeaponProficiency), "WeaponProficiency")]
    [JsonDerivedType(typeof(ToolProficiency), "ToolProficiency")]
    [JsonDerivedType(typeof(ArmorProficiency), "ArmorProficiency")]
    [JsonDerivedType(typeof(SavingThrowProficiency), "SavingThrowProficiency")]
    [JsonDerivedType(typeof(ProficiencyGroup), "ProficiencyGroup")]
    public abstract class Proficiency { }
}
