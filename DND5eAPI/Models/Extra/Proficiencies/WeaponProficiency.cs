using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class WeaponProficiency(string weaponType) : Proficiency
    {
        public override string ProficiencyType => "WeaponProficiency";
        public int WeaponTypeId { get; set; } = WeaponTypesData.WeaponTypes.FirstOrDefault(wt => wt.Name == weaponType)!.Id;
    }
}
