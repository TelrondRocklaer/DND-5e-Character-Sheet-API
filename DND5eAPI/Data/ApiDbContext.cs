using Microsoft.EntityFrameworkCore;
using DND5eAPI.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DND5eAPI.Models.Extra.Effects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DND5eAPI.Utilities;

namespace DND5eAPI.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var clrType = entityType.ClrType;
                var effectProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Effects");
                if (effectProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(effectProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Effect>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Effect>>(v, JsonSerializerOptions.Default) ?? new List<Effect>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Effect>>(
                            (c1, c2) => c1 != null && c2 != null && c1.SequenceEqual(c2, new EffectComparer()),
                            c => c != null ? c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())) : 0,
                            c => c != null ? c.Select(e => e).ToList() : new List<Effect>()
                    ));
                }
            }
        }

        public DbSet<Armor> Armor { get; set; } = default!;
        public DbSet<ArmorType> ArmorType { get; set; } = default!;
        public DbSet<Background> Background { get; set; } = default!;
        public DbSet<Class> Class { get; set; } = default!;
        public DbSet<Condition> Condition { get; set; } = default!;
        public DbSet<Equipment> Equipment { get; set; } = default!;
        public DbSet<EquipmentCategory> EquipmentCategory { get; set; } = default!;
        public DbSet<Feat> Feat { get; set; } = default!;
        public DbSet<Language> Language { get; set; } = default!;
        public DbSet<Race> Race { get; set; } = default!;
        public DbSet<Spell> Spell { get; set; } = default!;
        public DbSet<Tool> Tool { get; set; } = default!;
        public DbSet<Trait> Trait { get; set; } = default!;
        public DbSet<Weapon> Weapon { get; set; } = default!;
        public DbSet<WeaponProperty> WeaponProperty { get; set; } = default!;
        public DbSet<WeaponType> WeaponType { get; set; } = default!;
        public DbSet<Deity> Deity { get; set; } = default!;
    }
}
