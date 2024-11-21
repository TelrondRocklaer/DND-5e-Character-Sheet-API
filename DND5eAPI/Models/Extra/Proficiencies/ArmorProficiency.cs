using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ArmorProficiency(string armorType) : Proficiency
    {
        public override string ProficiencyType => "ArmorProficiency";

        public int ArmorTypeId { get; set; } = ArmorTypesData.ArmorTypes.FirstOrDefault(at => at.Name == armorType)!.Id;
    }
}
