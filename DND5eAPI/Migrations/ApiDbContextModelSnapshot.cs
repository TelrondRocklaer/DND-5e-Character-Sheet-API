﻿// <auto-generated />
using System;
using DND5eAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DND5eAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArmorSpell", b =>
                {
                    b.Property<int>("ArmorsId")
                        .HasColumnType("int");

                    b.Property<int>("SpellsId")
                        .HasColumnType("int");

                    b.HasKey("ArmorsId", "SpellsId");

                    b.HasIndex("SpellsId");

                    b.ToTable("ArmorSpell");
                });

            modelBuilder.Entity("ArmorTrait", b =>
                {
                    b.Property<int>("ArmorsId")
                        .HasColumnType("int");

                    b.Property<int>("TraitsId")
                        .HasColumnType("int");

                    b.HasKey("ArmorsId", "TraitsId");

                    b.HasIndex("TraitsId");

                    b.ToTable("ArmorTrait");
                });

            modelBuilder.Entity("ArmorTypeClass", b =>
                {
                    b.Property<int>("ArmorProficienciesId")
                        .HasColumnType("int");

                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.HasKey("ArmorProficienciesId", "ClassesId");

                    b.HasIndex("ClassesId");

                    b.ToTable("ArmorTypeClass");
                });

            modelBuilder.Entity("BackgroundEquipment", b =>
                {
                    b.Property<int>("BackgroundsId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("BackgroundsId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("BackgroundEquipment");
                });

            modelBuilder.Entity("BackgroundFeat", b =>
                {
                    b.Property<int>("BackgroundsId")
                        .HasColumnType("int");

                    b.Property<int>("FeatsId")
                        .HasColumnType("int");

                    b.HasKey("BackgroundsId", "FeatsId");

                    b.HasIndex("FeatsId");

                    b.ToTable("BackgroundFeat");
                });

            modelBuilder.Entity("BackgroundTool", b =>
                {
                    b.Property<int>("BackgroundsId")
                        .HasColumnType("int");

                    b.Property<int>("ToolProficienciesId")
                        .HasColumnType("int");

                    b.HasKey("BackgroundsId", "ToolProficienciesId");

                    b.HasIndex("ToolProficienciesId");

                    b.ToTable("BackgroundTool");
                });

            modelBuilder.Entity("BackgroundTrait", b =>
                {
                    b.Property<int>("BackgroundsId")
                        .HasColumnType("int");

                    b.Property<int>("TraitsId")
                        .HasColumnType("int");

                    b.HasKey("BackgroundsId", "TraitsId");

                    b.HasIndex("TraitsId");

                    b.ToTable("BackgroundTrait");
                });

            modelBuilder.Entity("ClassSpell", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("SpellsId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "SpellsId");

                    b.HasIndex("SpellsId");

                    b.ToTable("ClassSpell");
                });

            modelBuilder.Entity("ClassTool", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("ToolProficienciesId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "ToolProficienciesId");

                    b.HasIndex("ToolProficienciesId");

                    b.ToTable("ClassTool");
                });

            modelBuilder.Entity("ClassTrait", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("TraitsId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "TraitsId");

                    b.HasIndex("TraitsId");

                    b.ToTable("ClassTrait");
                });

            modelBuilder.Entity("ClassWeaponType", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponProficienciesId")
                        .HasColumnType("int");

                    b.HasKey("ClassesId", "WeaponProficienciesId");

                    b.HasIndex("WeaponProficienciesId");

                    b.ToTable("ClassWeaponType");
                });

            modelBuilder.Entity("DND5eAPI.Models.Armor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmorTypeId")
                        .HasColumnType("int");

                    b.Property<int>("BaseArmorClass")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ArmorTypeId");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("DND5eAPI.Models.ArmorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArmorTypes");
                });

            modelBuilder.Entity("DND5eAPI.Models.Background", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillProficiencies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StartingGold")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("DND5eAPI.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Effects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HitDie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSkillsToChoose")
                        .HasColumnType("int");

                    b.Property<string>("PrimaryAbility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillProficiencyOptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartingGold")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DND5eAPI.Models.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("DND5eAPI.Models.Deity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deities");
                });

            modelBuilder.Entity("DND5eAPI.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentCategoryId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DND5eAPI.Models.EquipmentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentCategories");
                });

            modelBuilder.Entity("DND5eAPI.Models.Feat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feats");
                });

            modelBuilder.Entity("DND5eAPI.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DND5eAPI.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseMovementSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DND5eAPI.Models.Spell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Concentration")
                        .HasColumnType("bit");

                    b.Property<int>("ConditionId")
                        .HasColumnType("int");

                    b.Property<string>("DamageString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRecuringOnMove")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRitual")
                        .HasColumnType("bit");

                    b.Property<bool>("MaterialComponent")
                        .HasColumnType("bit");

                    b.Property<string>("MaterialComponentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SomaticComponent")
                        .HasColumnType("bit");

                    b.Property<string>("SpellSlotLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpcastEffect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VerbalComponent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("DND5eAPI.Models.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("DND5eAPI.Models.Trait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("DND5eAPI.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AttunementRequired")
                        .HasColumnType("bit");

                    b.Property<int>("ConditionId")
                        .HasColumnType("int");

                    b.Property<string>("DamageString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Effects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MagicBonus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeaponTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("WeaponTypeId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("DND5eAPI.Models.WeaponProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeaponProperties");
                });

            modelBuilder.Entity("DND5eAPI.Models.WeaponType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeaponTypes");
                });

            modelBuilder.Entity("LanguageRace", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("RacesId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "RacesId");

                    b.HasIndex("RacesId");

                    b.ToTable("LanguageRace");
                });

            modelBuilder.Entity("RaceTrait", b =>
                {
                    b.Property<int>("RacesId")
                        .HasColumnType("int");

                    b.Property<int>("TraitsId")
                        .HasColumnType("int");

                    b.HasKey("RacesId", "TraitsId");

                    b.HasIndex("TraitsId");

                    b.ToTable("RaceTrait");
                });

            modelBuilder.Entity("SpellWeapon", b =>
                {
                    b.Property<int>("SpellsId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponsId")
                        .HasColumnType("int");

                    b.HasKey("SpellsId", "WeaponsId");

                    b.HasIndex("WeaponsId");

                    b.ToTable("SpellWeapon");
                });

            modelBuilder.Entity("TraitWeapon", b =>
                {
                    b.Property<int>("TraitsId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponsId")
                        .HasColumnType("int");

                    b.HasKey("TraitsId", "WeaponsId");

                    b.HasIndex("WeaponsId");

                    b.ToTable("TraitWeapon");
                });

            modelBuilder.Entity("WeaponPropertyWeaponType", b =>
                {
                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponTypesId")
                        .HasColumnType("int");

                    b.HasKey("PropertiesId", "WeaponTypesId");

                    b.HasIndex("WeaponTypesId");

                    b.ToTable("WeaponPropertyWeaponType");
                });

            modelBuilder.Entity("ArmorSpell", b =>
                {
                    b.HasOne("DND5eAPI.Models.Armor", null)
                        .WithMany()
                        .HasForeignKey("ArmorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Spell", null)
                        .WithMany()
                        .HasForeignKey("SpellsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArmorTrait", b =>
                {
                    b.HasOne("DND5eAPI.Models.Armor", null)
                        .WithMany()
                        .HasForeignKey("ArmorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArmorTypeClass", b =>
                {
                    b.HasOne("DND5eAPI.Models.ArmorType", null)
                        .WithMany()
                        .HasForeignKey("ArmorProficienciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackgroundEquipment", b =>
                {
                    b.HasOne("DND5eAPI.Models.Background", null)
                        .WithMany()
                        .HasForeignKey("BackgroundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackgroundFeat", b =>
                {
                    b.HasOne("DND5eAPI.Models.Background", null)
                        .WithMany()
                        .HasForeignKey("BackgroundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Feat", null)
                        .WithMany()
                        .HasForeignKey("FeatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackgroundTool", b =>
                {
                    b.HasOne("DND5eAPI.Models.Background", null)
                        .WithMany()
                        .HasForeignKey("BackgroundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Tool", null)
                        .WithMany()
                        .HasForeignKey("ToolProficienciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackgroundTrait", b =>
                {
                    b.HasOne("DND5eAPI.Models.Background", null)
                        .WithMany()
                        .HasForeignKey("BackgroundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassSpell", b =>
                {
                    b.HasOne("DND5eAPI.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Spell", null)
                        .WithMany()
                        .HasForeignKey("SpellsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassTool", b =>
                {
                    b.HasOne("DND5eAPI.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Tool", null)
                        .WithMany()
                        .HasForeignKey("ToolProficienciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassTrait", b =>
                {
                    b.HasOne("DND5eAPI.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassWeaponType", b =>
                {
                    b.HasOne("DND5eAPI.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.WeaponType", null)
                        .WithMany()
                        .HasForeignKey("WeaponProficienciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DND5eAPI.Models.Armor", b =>
                {
                    b.HasOne("DND5eAPI.Models.ArmorType", "ArmorType")
                        .WithMany("Armors")
                        .HasForeignKey("ArmorTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArmorType");
                });

            modelBuilder.Entity("DND5eAPI.Models.Equipment", b =>
                {
                    b.HasOne("DND5eAPI.Models.EquipmentCategory", "EquipmentCategory")
                        .WithMany("Equipment")
                        .HasForeignKey("EquipmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentCategory");
                });

            modelBuilder.Entity("DND5eAPI.Models.Language", b =>
                {
                    b.HasOne("DND5eAPI.Models.Background", null)
                        .WithMany("Languages")
                        .HasForeignKey("BackgroundId");
                });

            modelBuilder.Entity("DND5eAPI.Models.Spell", b =>
                {
                    b.HasOne("DND5eAPI.Models.Condition", "Condition")
                        .WithMany("Spells")
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condition");
                });

            modelBuilder.Entity("DND5eAPI.Models.Weapon", b =>
                {
                    b.HasOne("DND5eAPI.Models.Condition", "Condition")
                        .WithMany("Weapons")
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.WeaponType", "WeaponType")
                        .WithMany("Weapons")
                        .HasForeignKey("WeaponTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condition");

                    b.Navigation("WeaponType");
                });

            modelBuilder.Entity("LanguageRace", b =>
                {
                    b.HasOne("DND5eAPI.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceTrait", b =>
                {
                    b.HasOne("DND5eAPI.Models.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpellWeapon", b =>
                {
                    b.HasOne("DND5eAPI.Models.Spell", null)
                        .WithMany()
                        .HasForeignKey("SpellsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Weapon", null)
                        .WithMany()
                        .HasForeignKey("WeaponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TraitWeapon", b =>
                {
                    b.HasOne("DND5eAPI.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.Weapon", null)
                        .WithMany()
                        .HasForeignKey("WeaponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeaponPropertyWeaponType", b =>
                {
                    b.HasOne("DND5eAPI.Models.WeaponProperty", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DND5eAPI.Models.WeaponType", null)
                        .WithMany()
                        .HasForeignKey("WeaponTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DND5eAPI.Models.ArmorType", b =>
                {
                    b.Navigation("Armors");
                });

            modelBuilder.Entity("DND5eAPI.Models.Background", b =>
                {
                    b.Navigation("Languages");
                });

            modelBuilder.Entity("DND5eAPI.Models.Condition", b =>
                {
                    b.Navigation("Spells");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("DND5eAPI.Models.EquipmentCategory", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("DND5eAPI.Models.WeaponType", b =>
                {
                    b.Navigation("Weapons");
                });
#pragma warning restore 612, 618
        }
    }
}
