using Microsoft.EntityFrameworkCore;
using DND5eAPI.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DND5eAPI.Models.Extra.Effects;
using DND5eAPI.Models.Extra;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DND5eAPI.Data.SeedData;
using DND5eAPI.Models.Extra.Proficiencies;

namespace DND5eAPI.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityTypes = modelBuilder.Model.GetEntityTypes().ToList();
            foreach (var entityType in entityTypes)
            {
                var clrType = entityType.ClrType;
                var effectProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Effects");
                var proficiencyProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Proficiencies");
                var toolProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Tools");
                var backgroundProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Backgrounds");
                var spellProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Spells");
                var equipmentProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Equipment");
                var weaponProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Weapons");
                var traitProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Traits");
                var armorProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Armors");
                var classProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Classes");
                var featProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Feats");
                var languageProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Languages");
                var subclassProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Subclasses");
                var startingEquipmentProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "StartingEquipment");
                var equipedArmorProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "EquipedArmor");
                var equipedWeaponProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "EquipedWeapons");
                var propertiesProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Properties");
                var raceProperty = clrType.GetProperties().FirstOrDefault(p => p.Name == "Races");
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
                if (proficiencyProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(proficiencyProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Proficiency>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Proficiency>>(v, JsonSerializerOptions.Default) ?? new List<Proficiency>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Proficiency>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Proficiency>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Proficiency>()
                    ));
                }
                if (toolProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(toolProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Tool>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Tool>>(v, JsonSerializerOptions.Default) ?? new List<Tool>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Tool>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Tool>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Tool>()
                    ));
                }
                if (backgroundProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(backgroundProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Background>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Background>>(v, JsonSerializerOptions.Default) ?? new List<Background>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Background>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Background>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Background>()
                    ));
                }
                if (spellProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(spellProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Spell>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Spell>>(v, JsonSerializerOptions.Default) ?? new List<Spell>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Spell>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Spell>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Spell>()
                    ));
                }
                if (equipmentProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(equipmentProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Equipment>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Equipment>>(v, JsonSerializerOptions.Default) ?? new List<Equipment>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Equipment>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Equipment>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Equipment>()
                    ));
                }
                if (weaponProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(weaponProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Weapon>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Weapon>>(v, JsonSerializerOptions.Default) ?? new List<Weapon>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Weapon>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Weapon>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Weapon>()
                    ));
                }
                if (traitProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(traitProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Trait>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Trait>>(v, JsonSerializerOptions.Default) ?? new List<Trait>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Trait>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Trait>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Trait>()
                    ));
                }
                if (armorProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(armorProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Armor>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Armor>>(v, JsonSerializerOptions.Default) ?? new List<Armor>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Armor>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Armor>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Armor>()
                    ));
                }
                if (classProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(classProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Class>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Class>>(v, JsonSerializerOptions.Default) ?? new List<Class>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Class>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Class>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Class>()
                    ));
                }
                if (featProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(featProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Feat>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Feat>>(v, JsonSerializerOptions.Default) ?? new List<Feat>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Feat>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Feat>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Feat>()
                    ));
                }
                if (languageProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(languageProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Language>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Language>>(v, JsonSerializerOptions.Default) ?? new List<Language>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Language>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Language>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Language>()
                    ));
                }
                if (subclassProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(subclassProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Subclass>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Subclass>>(v, JsonSerializerOptions.Default) ?? new List<Subclass>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Subclass>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Subclass>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Subclass>()
                    ));
                }
                if (startingEquipmentProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(startingEquipmentProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Equipment>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Equipment>>(v, JsonSerializerOptions.Default) ?? new List<Equipment>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Equipment>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Equipment>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Equipment>()
                    ));
                }
                if (equipedArmorProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(equipedArmorProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Armor>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Armor>>(v, JsonSerializerOptions.Default) ?? new List<Armor>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Armor>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Armor>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Armor>()
                    ));
                }
                if (equipedWeaponProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(equipedWeaponProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Weapon>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Weapon>>(v, JsonSerializerOptions.Default) ?? new List<Weapon>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Weapon>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Weapon>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Weapon>()
                    ));
                }
                if (propertiesProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(propertiesProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<WeaponProperty>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<WeaponProperty>>(v, JsonSerializerOptions.Default) ?? new List<WeaponProperty>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<WeaponProperty>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<WeaponProperty>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<WeaponProperty>()
                    ));
                }
                if (raceProperty != null)
                {
                    modelBuilder.Entity(clrType).Property(raceProperty.Name)
                        .HasConversion(new ValueConverter<ICollection<Race>, string>(
                            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                            v => JsonSerializer.Deserialize<ICollection<Race>>(v, JsonSerializerOptions.Default) ?? new List<Race>()))
                        .Metadata.SetValueComparer(new ValueComparer<ICollection<Race>>(
                            (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                            c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                            c => JsonSerializer.Deserialize<ICollection<Race>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Race>()
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

            modelBuilder.Entity<PlayerCharacter>().Property(pc => pc.Notes)
                .HasConversion(new ValueConverter<List<Note>?, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<List<Note>>(v, JsonSerializerOptions.Default) ?? new List<Note>()))
                .Metadata.SetValueComparer(new ValueComparer<List<Note>>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<List<Note>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Note>()
            ));

            modelBuilder.Entity<PlayerCharacter>().Property(pc => pc.SpellSlots)
                .HasConversion(new ValueConverter<List<SpellSlotDataNode>?, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<List<SpellSlotDataNode>>(v, JsonSerializerOptions.Default) ?? new List<SpellSlotDataNode>()))
                .Metadata.SetValueComparer(new ValueComparer<List<SpellSlotDataNode>>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<List<SpellSlotDataNode>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<SpellSlotDataNode>()
            ));

            modelBuilder.Entity<PlayerCharacter>().Property(pc => pc.Attributes)
                .HasConversion(new ValueConverter<Attributes, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<Attributes>(v, JsonSerializerOptions.Default) ?? new Attributes()))
                .Metadata.SetValueComparer(new ValueComparer<Attributes>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<Attributes>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new Attributes(0, 0, 0, 0, 0, 0)
            ));

            modelBuilder.Entity<Tool>().Property(t => t.CraftableItems)
                .HasConversion(new ValueConverter<ICollection<Equipment>, string>(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<ICollection<Equipment>>(v, JsonSerializerOptions.Default) ?? new List<Equipment>()))
                .Metadata.SetValueComparer(new ValueComparer<ICollection<Equipment>>(
                    (c1, c2) => JsonSerializer.Serialize(c1, JsonSerializerOptions.Default) == JsonSerializer.Serialize(c2, JsonSerializerOptions.Default),
                    c => c == null ? 0 : JsonSerializer.Serialize(c, JsonSerializerOptions.Default).GetHashCode(),
                    c => JsonSerializer.Deserialize<ICollection<Equipment>>(JsonSerializer.Serialize(c, JsonSerializerOptions.Default), JsonSerializerOptions.Default) ?? new List<Equipment>()
            ));

            modelBuilder.Entity<ArmorType>().HasData(ArmorTypesData.ArmorTypes);
            modelBuilder.Entity<Background>().HasData(BackgroundsData.Backgrounds);
            modelBuilder.Entity<Class>().HasData(ClassesData.Classes);
            modelBuilder.Entity<Condition>().HasData(ConditionsData.Conditions);
            modelBuilder.Entity<Deity>().HasData(DeitiesData.Deities);
            modelBuilder.Entity<EquipmentCategory>().HasData(EquipmentCategoriesData.EquipmentCategories);
            modelBuilder.Entity<Language>().HasData(LanguagesData.Languages);
            modelBuilder.Entity<PlayerCharacter>().HasData(PlayerCharactersData.PlayerCharacters);
            modelBuilder.Entity<Race>().HasData(RacesData.Races);
            modelBuilder.Entity<Spell>().HasData(SpellsData.Spells);
            modelBuilder.Entity<Subrace>().HasData(SubracesData.Subraces);
            modelBuilder.Entity<Tool>().HasData(ToolsData.Tools);
            modelBuilder.Entity<Trait>().HasData(TraitsData.Traits);
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
