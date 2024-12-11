using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class WeaponProficiency : Proficiency
    {
        public int WeaponTypeId { get; set; }

        public WeaponProficiency() { }

        public WeaponProficiency(string weaponType)
        {
            WeaponTypeId = WeaponTypesData.WeaponTypes.FirstOrDefault(wt => wt.Name == weaponType)!.Id;
        }
    }
}
