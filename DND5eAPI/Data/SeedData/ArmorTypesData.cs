using DND5eAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Data.SeedData
{
    public static class ArmorTypesData
    {
        public static readonly ArmorType Clothing = new() { Id = 1, Name = "Clothing" };
        public static readonly ArmorType Light = new() { Id = 2, Name = "Light" };
        public static readonly ArmorType Medium = new() { Id = 3, Name = "Medium" };
        public static readonly ArmorType Heavy = new() { Id = 4, Name = "Heavy" };
        public static readonly ArmorType Shield = new() { Id = 5, Name = "Shield" };

        public static ArmorType[] ArmorTypes = [Clothing, Light, Medium, Heavy, Shield];
    }
}
