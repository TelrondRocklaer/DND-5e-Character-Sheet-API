using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class EquipmentCategoriesData
    {
        public static readonly EquipmentCategory EquipmentPack = new() { Id = 1, Name = "Equipment Pack" };
        public static readonly EquipmentCategory Potion = new() { Id = 2, Name = "Potion" };
        public static readonly EquipmentCategory MagicScroll = new() { Id = 3, Name = "Magic Scroll" };
        public static readonly EquipmentCategory Mount = new() { Id = 4, Name = "Mount" };
        public static readonly EquipmentCategory AdventuringGear = new() { Id = 5, Name = "Adventuring Gear" };
        public static readonly EquipmentCategory Poison = new() { Id = 6, Name = "Poison" };

        public static EquipmentCategory[] EquipmentCategories = [
            EquipmentPack,
            Potion, 
            MagicScroll, 
            Mount, 
            AdventuringGear, 
            Poison
        ];
    }
}
