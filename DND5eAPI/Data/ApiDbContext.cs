using Microsoft.EntityFrameworkCore;
using DND5eAPI.Models;

namespace DND5eAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext (DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Armor> Armor { get; set; } = default!;
        public DbSet<ArmorType> ArmorType { get; set; } = default!;
        public DbSet<Background> Background { get; set; } = default!;
        public DbSet<Class> Class { get; set; } = default!;
        public DbSet<Condition> Condition { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Equipment> Equipment { get; set; } = default!;
        public DbSet<DND5eAPI.Models.EquipmentCategory> EquipmentCategory { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Feat> Feat { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Language> Language { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Race> Race { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Spell> Spell { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Tool> Tool { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Trait> Trait { get; set; } = default!;
        public DbSet<DND5eAPI.Models.Weapon> Weapon { get; set; } = default!;
        public DbSet<DND5eAPI.Models.WeaponProperty> WeaponProperty { get; set; } = default!;
        public DbSet<DND5eAPI.Models.WeaponType> WeaponType { get; set; } = default!;
    }
}
