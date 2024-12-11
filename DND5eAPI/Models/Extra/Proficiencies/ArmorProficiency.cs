using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ArmorProficiency : Proficiency
    {
        public int ArmorTypeId { get; set; }

        public ArmorProficiency() { }

        public ArmorProficiency(string armorType)
        {
            ArmorTypeId = ArmorTypesData.ArmorTypes.FirstOrDefault(at => at.Name == armorType)!.Id;
        }
    }
}
