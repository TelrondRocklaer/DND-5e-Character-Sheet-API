using Microsoft.EntityFrameworkCore;
using DND5eAPI.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DND5eAPI.Models.Extra.Effects;
using DND5eAPI.Models.Extra;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DND5eAPI.Data.SeedData;

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
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Effect>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Effect>()
                    ));
                }
            }

            modelBuilder.Entity<Tool>().Property(t => t.Actions)
                .HasConversion(new ValueConverter<ICollection<ToolAction>, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<ICollection<ToolAction>>(v, JsonSerializerOptions.Default) ?? new List<ToolAction>()))
                .Metadata.SetValueComparer(new ValueComparer<ICollection<ToolAction>>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<ICollection<ToolAction>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<ToolAction>()
            ));

            modelBuilder.Entity<WeaponType>().Property(w => w.Properties)
                .HasConversion(new ValueConverter<ICollection<WeaponProperty>, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<ICollection<WeaponProperty>>(v, JsonSerializerOptions.Default) ?? new List<WeaponProperty>()))
                .Metadata.SetValueComparer(new ValueComparer<ICollection<WeaponProperty>>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<ICollection<WeaponProperty>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<WeaponProperty>()
            ));

            modelBuilder.Entity<ArmorType>().HasData(ArmorTypesData.ArmorTypes);
            modelBuilder.Entity<Condition>().HasData(ConditionsData.Conditions);
            modelBuilder.Entity<Deity>().HasData(DeitiesData.Deities);
            modelBuilder.Entity<EquipmentCategory>().HasData(EquipmentCategoriesData.EquipmentCategories);
            modelBuilder.Entity<Language>().HasData(LanguagesData.Languages);
            modelBuilder.Entity<Race>().HasData(RacesData.Races);
            modelBuilder.Entity<Spell>().HasData(SpellsData.Spells);
            modelBuilder.Entity<Subrace>().HasData(SubracesData.Subraces);
            modelBuilder.Entity<Tool>().HasData(ToolsData.Tools);
            modelBuilder.Entity<WeaponType>().HasData(WeaponTypesData.WeaponTypes);
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
        public DbSet<PlayerCharacter> PlayerCharacter { get; set; } = default!;
        public DbSet<Race> Race { get; set; } = default!;
        public DbSet<Spell> Spell { get; set; } = default!;
        public DbSet<Tool> Tool { get; set; } = default!;
        public DbSet<Trait> Trait { get; set; } = default!;
        public DbSet<Weapon> Weapon { get; set; } = default!;
        public DbSet<WeaponType> WeaponType { get; set; } = default!;
        public DbSet<Deity> Deity { get; set; } = default!;
        public DbSet<Subrace> Subrace { get; set; } = default!;
        public DbSet<Subclass> Subclass { get; set; } = default!;
    }
}
