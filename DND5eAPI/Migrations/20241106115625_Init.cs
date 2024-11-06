using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND5eAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillProficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingGold = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSkillsToChoose = table.Column<int>(type: "int", nullable: false),
                    SkillProficiencyOptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingGold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseMovementSpeed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMartial = table.Column<bool>(type: "bit", nullable: false),
                    BaseDamage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseCost = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArmorTypeClass",
                columns: table => new
                {
                    ArmorProficienciesId = table.Column<int>(type: "int", nullable: false),
                    ClassesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorTypeClass", x => new { x.ArmorProficienciesId, x.ClassesId });
                    table.ForeignKey(
                        name: "FK_ArmorTypeClass_ArmorTypes_ArmorProficienciesId",
                        column: x => x.ArmorProficienciesId,
                        principalTable: "ArmorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorTypeClass_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subclasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subclasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subclasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subraces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentRaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subraces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subraces_Races_ParentRaceId",
                        column: x => x.ParentRaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassWeaponType",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    WeaponProficienciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassWeaponType", x => new { x.ClassesId, x.WeaponProficienciesId });
                    table.ForeignKey(
                        name: "FK_ClassWeaponType_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassWeaponType_WeaponTypes_WeaponProficienciesId",
                        column: x => x.WeaponProficienciesId,
                        principalTable: "WeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageRace",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    RacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageRace", x => new { x.LanguagesId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_LanguageRace_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageRace_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    MaxHitPoints = table.Column<int>(type: "int", nullable: false),
                    CurrentHitPoints = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPoints = table.Column<int>(type: "int", nullable: false),
                    MovementSpeed = table.Column<int>(type: "int", nullable: false),
                    NumberOfActions = table.Column<int>(type: "int", nullable: false),
                    NumberOfBonusActions = table.Column<int>(type: "int", nullable: false),
                    NumberOfReactions = table.Column<int>(type: "int", nullable: false),
                    SpecialPoints = table.Column<int>(type: "int", nullable: false),
                    CurrentSpecialPoints = table.Column<int>(type: "int", nullable: false),
                    WearsArmor = table.Column<bool>(type: "bit", nullable: false),
                    WearsMetalArmor = table.Column<bool>(type: "bit", nullable: false),
                    IsShieldEquipped = table.Column<bool>(type: "bit", nullable: false),
                    HasAdvantageOnConcentrationSavingThrows = table.Column<bool>(type: "bit", nullable: false),
                    HasDisadvantageOnConcentrationSavingThrows = table.Column<bool>(type: "bit", nullable: false),
                    HasAdvantageOnAttackRolls = table.Column<bool>(type: "bit", nullable: false),
                    HasDisadvantageOnAttackRolls = table.Column<bool>(type: "bit", nullable: false),
                    AttackersHaveAdvantageOnAttackRolls = table.Column<bool>(type: "bit", nullable: false),
                    AttackersHaveDisadvantageOnAttackRolls = table.Column<bool>(type: "bit", nullable: false),
                    HasAdvantageOnAbilityChecks = table.Column<bool>(type: "bit", nullable: false),
                    HasDisadvantageOnAbilityChecks = table.Column<bool>(type: "bit", nullable: false),
                    SpellAttackRollBonus = table.Column<int>(type: "int", nullable: false),
                    WeaponAttackRollBonus = table.Column<int>(type: "int", nullable: false),
                    IsConcentrating = table.Column<bool>(type: "bit", nullable: false),
                    IsThreataned = table.Column<bool>(type: "bit", nullable: false),
                    ExhaustionLevel = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    SubraceId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubclassId = table.Column<int>(type: "int", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Subclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Subraces_SubraceId",
                        column: x => x.SubraceId,
                        principalTable: "Subraces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    BaseArmorClass = table.Column<int>(type: "int", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorTypeId = table.Column<int>(type: "int", nullable: false),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Armors_ArmorTypes_ArmorTypeId",
                        column: x => x.ArmorTypeId,
                        principalTable: "ArmorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Armors_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentCategoryId = table.Column<int>(type: "int", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentCategories_EquipmentCategoryId",
                        column: x => x.EquipmentCategoryId,
                        principalTable: "EquipmentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feats_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanTargetSelf = table.Column<bool>(type: "bit", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellSlotLevel = table.Column<int>(type: "int", nullable: false),
                    UpcastEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpgradeLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseNumberOfCasts = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerbalComponent = table.Column<bool>(type: "bit", nullable: false),
                    SomaticComponent = table.Column<bool>(type: "bit", nullable: false),
                    MaterialComponent = table.Column<bool>(type: "bit", nullable: false),
                    MaterialComponentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRitual = table.Column<bool>(type: "bit", nullable: false),
                    Concentration = table.Column<bool>(type: "bit", nullable: false),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: false),
                    IsRecurringOnMove = table.Column<bool>(type: "bit", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubclassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Spells_Subclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tools_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubclassId = table.Column<int>(type: "int", nullable: true),
                    SubraceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traits_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Traits_Subclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Traits_Subraces_SubraceId",
                        column: x => x.SubraceId,
                        principalTable: "Subraces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagicBonus = table.Column<int>(type: "int", nullable: false),
                    WeaponTypeId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Effects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttunementRequired = table.Column<bool>(type: "bit", nullable: false),
                    ConditionId = table.Column<int>(type: "int", nullable: true),
                    PlayerCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponTypes_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "WeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundEquipment",
                columns: table => new
                {
                    BackgroundsId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundEquipment", x => new { x.BackgroundsId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_BackgroundEquipment_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundEquipment_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundFeat",
                columns: table => new
                {
                    BackgroundsId = table.Column<int>(type: "int", nullable: false),
                    FeatsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundFeat", x => new { x.BackgroundsId, x.FeatsId });
                    table.ForeignKey(
                        name: "FK_BackgroundFeat_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundFeat_Feats_FeatsId",
                        column: x => x.FeatsId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorSpell",
                columns: table => new
                {
                    ArmorsId = table.Column<int>(type: "int", nullable: false),
                    SpellsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorSpell", x => new { x.ArmorsId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_ArmorSpell_Armors_ArmorsId",
                        column: x => x.ArmorsId,
                        principalTable: "Armors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorSpell_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSpell",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    SpellsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSpell", x => new { x.ClassesId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_ClassSpell_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSpell_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundTool",
                columns: table => new
                {
                    BackgroundsId = table.Column<int>(type: "int", nullable: false),
                    ToolProficienciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundTool", x => new { x.BackgroundsId, x.ToolProficienciesId });
                    table.ForeignKey(
                        name: "FK_BackgroundTool_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundTool_Tools_ToolProficienciesId",
                        column: x => x.ToolProficienciesId,
                        principalTable: "Tools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassTool",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    ToolProficienciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTool", x => new { x.ClassesId, x.ToolProficienciesId });
                    table.ForeignKey(
                        name: "FK_ClassTool_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTool_Tools_ToolProficienciesId",
                        column: x => x.ToolProficienciesId,
                        principalTable: "Tools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentTool",
                columns: table => new
                {
                    CraftableItemsId = table.Column<int>(type: "int", nullable: false),
                    ToolsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTool", x => new { x.CraftableItemsId, x.ToolsId });
                    table.ForeignKey(
                        name: "FK_EquipmentTool_Equipment_CraftableItemsId",
                        column: x => x.CraftableItemsId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentTool_Tools_ToolsId",
                        column: x => x.ToolsId,
                        principalTable: "Tools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorTrait",
                columns: table => new
                {
                    ArmorsId = table.Column<int>(type: "int", nullable: false),
                    TraitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorTrait", x => new { x.ArmorsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_ArmorTrait_Armors_ArmorsId",
                        column: x => x.ArmorsId,
                        principalTable: "Armors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundTrait",
                columns: table => new
                {
                    BackgroundsId = table.Column<int>(type: "int", nullable: false),
                    TraitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundTrait", x => new { x.BackgroundsId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_BackgroundTrait_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassTrait",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    TraitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTrait", x => new { x.ClassesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_ClassTrait_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceTrait",
                columns: table => new
                {
                    RacesId = table.Column<int>(type: "int", nullable: false),
                    TraitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTrait", x => new { x.RacesId, x.TraitsId });
                    table.ForeignKey(
                        name: "FK_RaceTrait_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceTrait_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellWeapon",
                columns: table => new
                {
                    SpellsId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellWeapon", x => new { x.SpellsId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_SpellWeapon_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellWeapon_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraitWeapon",
                columns: table => new
                {
                    TraitsId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitWeapon", x => new { x.TraitsId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_TraitWeapon_Traits_TraitsId",
                        column: x => x.TraitsId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraitWeapon_Weapons_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArmorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Clothing" },
                    { 2, "Light" },
                    { 3, "Medium" },
                    { 4, "Heavy" },
                    { 5, "Shield" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Effects", "Name" },
                values: new object[,]
                {
                    { 1, "While you have the Blinded condition, you experience the following effects. Can’t See. You can’t see and automatically fail any ability check that requires sight. Attacks Affected. Attack rolls against you have Advantage, and your attack rolls have Disadvantage.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Can\\u0027t see\",\"Description\":\"You can\\u2019t see and automatically fail any ability check that requires sight\"},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0}]", "Blinded" },
                    { 2, "While you have the Charmed condition, you experience the following effects. Can’t Harm the Charmer. You can’t attack the charmer or target the charmer with damaging abilities or magical effects. Social Advantage. The charmer has Advantage on any ability check to interact with you socially.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Can\\u0027t harm the charmer\",\"Description\":\"You can\\u2019t attack the charmer or target the charmer with damaging abilities or magical effects\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Social advantage\",\"Description\":\"The charmer has Advantage on any ability check to interact with you socially\"}]", "Charmed" },
                    { 3, "While you have the Deafened condition, you experience the following effect. Can’t Hear. You can’t hear and automatically fail any ability check that requires hearing.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Can\\u0027t hear\",\"Description\":\"You can\\u2019t hear and automatically fail any ability check that requires hearing\"}]", "Deafened" },
                    { 4, "While you have the Exhaustion condition, you experience the following effects. Exhaustion Levels. This condition is cumulative. Each time you receive it, you gain 1 Exhaustion level. You die if your Exhaustion level is 6. D20 Tests Affected. When you make a D20 Test, the roll is reduced by 2 times your Exhaustion level. Speed Reduced. Your Speed is reduced by a number of feet equal to 5 times your Exhaustion level. Removing Exhaustion Levels. Finishing a Long Rest removes 1 of your Exhaustion levels. When your Exhaustion level reaches 0, the condition ends.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Exhaustion levels\",\"Description\":\"This condition is cumulative. Each time you receive it, you gain 1 Exhaustion level. You die if your Exhaustion level is 6\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"D20 tests affected\",\"Description\":\"When you make a D20 Test, the roll is reduced by 2 times your Exhaustion level\"},{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Removing Exhaustion Levels\",\"Description\":\"Finishing a Long Rest removes 1 of your Exhaustion levels. When your Exhaustion level reaches 0, the condition ends\"}]", "Exhaustion" },
                    { 5, "While you have the Frightened condition, you experience the following effects. Ability Checks and Attacks Affected. You have Disadvantage on ability checks and attack rolls while the source of fear is within line of sight. Can’t Approach. You can’t willingly move closer to the source of fear.", "[{\"EffectType\":\"AbilityCheckEffect\",\"HasAdvantageOrDisadvantage\":false},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":null,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Can\\u0027t approach\",\"Description\":\"You can\\u2019t willingly move closer to the source of fear\"}]", "Frightened" },
                    { 6, "While you have the Grappled condition, you experience the following effects. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. You have Disadvantage on attack rolls against any target other than the grappler. Movable. The grappler can drag or carry you when it moves, but every foot of movement costs it 1 extra foot unless you are Tiny or two or more sizes smaller than it.", "[{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Attacks Affected\",\"Description\":\"You have Disadvantage on attack rolls against any target other than the grappler.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Movable\",\"Description\":\"The grappler can drag or carry you when it moves, but every foot of movement costs it 1 extra foot unless you are Tiny or two or more sizes smaller than it\"}]", "Grappled" },
                    { 7, "While you have the Incapacitated condition, you experience the following effects. Inactive. You can’t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can’t speak. Surprised. If you’re Incapacitated when you roll Initiative, you have Disadvantage on the roll.", "[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]", "Incapacitated" },
                    { 8, "While you have the Invisible condition, you experience the following effects. Surprise. If you’re Invisible when you roll Initiative, you have Advantage on the roll. Concealed. You aren’t affected by any effect that requires its target to be seen unless the effect’s creator can somehow see you. Any equipment you are wearing or carrying is also concealed. Attacks Affected. Attack rolls against you have Disadvantage, and your attack rolls have Advantage. If a creature can somehow see you, you don’t gain this benefit against that creature.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprise\",\"Description\":\"If you\\u2019re Invisible when you roll Initiative, you have Advantage on the roll.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Concealed\",\"Description\":\"You aren\\u2019t affected by any effect that requires its target to be seen unless the effect\\u2019s creator can somehow see you. Any equipment you are wearing or carrying is also concealed.\"},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":true,\"AttackersHaveAdvantageOrDisadvantage\":false,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0}]", "Invisible" },
                    { 9, "While you have the Paralyzed condition, you experience the following effects. Incapacitated. You have the Incapacitated condition. Speed 0. Your Speed is 0 and can’t increase. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Attacks Affected. Attack rolls against you have Advantage. Automatic Critical Hits. Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you", "[{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":7,\"Name\":\"Incapacitated\",\"Description\":\"While you have the Incapacitated condition, you experience the following effects. Inactive. You can\\u2019t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can\\u2019t speak. Surprised. If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\",\"Effects\":[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"strength\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":null,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Automatic Critical Hits\",\"Description\":\"Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.\"}]", "Paralyzed" },
                    { 10, "While you have the Petrified condition, you experience the following effects. Turned to Inanimate Substance. You are transformed, along with any nonmagical objects you are wearing and carrying, into a solid inanimate substance (usually stone). Your weight increases by a factor of ten, and you cease aging. Incapacitated. You have the Incapacitated condition. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Resist Damage. You have Resistance to all damage. Poison Immunity. You have Immunity to the Poisoned condition.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Turned to Inanimate Substance\",\"Description\":\"You are transformed, along with any nonmagical objects you are wearing and carrying, into a solid inanimate substance (usually stone). Your weight increases by a factor of ten, and you cease aging.\"},{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":7,\"Name\":\"Incapacitated\",\"Description\":\"While you have the Incapacitated condition, you experience the following effects. Inactive. You can\\u2019t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can\\u2019t speak. Surprised. If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\",\"Effects\":[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":null,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"strength\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Resist Damage\",\"Description\":\"You have Resistance to all damage.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Poison Immunity\",\"Description\":\"You have Immunity to the Poisoned condition.\"}]", "Petrified" },
                    { 11, "While you have the Poisoned condition, you experience the following effect. Ability Checks and Attacks Affected. You have Disadvantage on attack rolls and ability checks.", "[{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":null,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"AbilityCheckEffect\",\"HasAdvantageOrDisadvantage\":false}]", "Poisoned" },
                    { 12, "While you have the Prone condition, you experience the following effects. Restricted Movement. Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can’t right yourself. Attacks Affected. You have Disadvantage on attack rolls. An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.", "[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Restricted Movement\",\"Description\":\"Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can\\u2019t right yourself.\"},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":null,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Attacks Affected\",\"Description\":\"An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.\"}]", "Prone" },
                    { 13, "While you have the Restrained condition, you experience the following effects. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage, and your attack rolls have Disadvantage. Saving Throws Affected. You have Disadvantage on Dexterity saving throws.", "[{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":false,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":null}]", "Restrained" },
                    { 14, "While you have the Stunned condition, you experience the following effects. Incapacitated. You have the Incapacitated condition. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Attacks Affected. Attack rolls against you have Advantage.", "[{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":7,\"Name\":\"Incapacitated\",\"Description\":\"While you have the Incapacitated condition, you experience the following effects. Inactive. You can\\u2019t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can\\u2019t speak. Surprised. If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\",\"Effects\":[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"strength\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":null,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0}]", "Stunned" },
                    { 15, "While you have the Unconscious condition, you experience the following effects. Inert. You have the Incapacitated and Prone conditions, and you drop whatever you’re holding. When this condition ends, you remain Prone. Speed 0. Your Speed is 0 and can’t increase. Attacks Affected. Attack rolls against you have Advantage. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Automatic Critical Hits. Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you. Unaware. You’re unaware of your surroundings.", "[{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":7,\"Name\":\"Incapacitated\",\"Description\":\"While you have the Incapacitated condition, you experience the following effects. Inactive. You can\\u2019t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can\\u2019t speak. Surprised. If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\",\"Effects\":[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":12,\"Name\":\"Prone\",\"Description\":\"While you have the Prone condition, you experience the following effects. Restricted Movement. Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can\\u2019t right yourself. Attacks Affected. You have Disadvantage on attack rolls. An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.\",\"Effects\":[{\"EffectType\":\"EsotericEffect\",\"Name\":\"Restricted Movement\",\"Description\":\"Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can\\u2019t right yourself.\"},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":false,\"AttackersHaveAdvantageOrDisadvantage\":null,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Attacks Affected\",\"Description\":\"An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":null,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"strength\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Automatic Critical Hits\",\"Description\":\"Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Unaware\",\"Description\":\"You\\u2019re unaware of your surroundings.\"}]", "Unconscious" }
                });

            migrationBuilder.InsertData(
                table: "Deities",
                columns: new[] { "Id", "Alignment", "Description", "Domain", "Name" },
                values: new object[,]
                {
                    { 1, "Neutral Evil", "Goddess of winter", "Nature, Tempest", "Auril" },
                    { 2, "Lawful Neutral", "God of wizards", "Knowledge", "Azuth" },
                    { 3, "Lawful Evil", "God of tyranny", "War", "Bane" },
                    { 4, "Chaotic Evil", "Goddess of misfortune", "Trickery", "Beshaba" },
                    { 5, "Neutral Evil", "God of murder", "Death", "Bhaal" },
                    { 6, "Neutral Good", "Goddess of agriculture", "Life", "Chauntea" },
                    { 7, "Chaotic Evil", "God of lies", "Trickery", "Cyric" },
                    { 8, "Neutral Good", "God of writing", "Knowledge", "Deneir" },
                    { 9, "Neutral Good", "Goddess of peace", "Life, Nature", "Eldath" },
                    { 10, "True Neutral", "God of craft", "Knowledge", "Gond" },
                    { 11, "Lawful Neutral", "God of protection", "Life, Light", "Helm" },
                    { 12, "Lawful Good", "God of endurance", "Life", "Ilmater" },
                    { 13, "Lawful Neutral", "God of the dead", "Death", "Kelemvor" },
                    { 14, "Neutral Good", "God of birth and renewal", "Life, Light", "Lathander" },
                    { 15, "Chaotic Neutral", "Goddess of illusion", "Trickery", "Leira" },
                    { 16, "Chaotic Good", "Goddess of joy", "Life", "Lliira" },
                    { 17, "Lawful Evil", "Goddess of pain", "Death", "Loviatar" },
                    { 18, "Chaotic Evil", "God of the hunt", "Nature", "Malar" },
                    { 19, "Neutral Evil", "God of thieves", "Trickery", "Mask" },
                    { 20, "Neutral Good", "Goddess of forests", "Nature", "Mielikki" },
                    { 21, "Neutral Good", "God of poetry and song", "Light", "Milil" },
                    { 22, "Neutral Evil", "God of death", "Death", "Myrkul" },
                    { 23, "Neutral Good", "Goddess of magic", "Knowledge", "Mystra" },
                    { 24, "True Neutral", "God of knowledge", "Knowledge", "Oghma" },
                    { 25, "Lawful Neutral", "God of divination and fate", "Knowledge", "Savras" },
                    { 26, "Chaotic Good", "Goddess of the moon", "Knowledge, Life", "Selûne" },
                    { 27, "Neutral Evil", "Goddess of darkness and loss", "Death, Trickery", "Shar" },
                    { 28, "True Neutral", "God of wild nature", "Nature", "Silvanus" },
                    { 29, "Chaotic Good", "Goddess of love and beauty", "Life, Light", "Sune" },
                    { 30, "Chaotic Evil", "Goddess of disease and poison", "Death", "Talona" },
                    { 31, "Chaotic Evil", "God of storms", "Tempest", "Talos" },
                    { 32, "True Neutral", "God of war", "War", "Tempus" },
                    { 33, "Lawful Good", "God of courage and self-sacrifice", "War", "Torm" },
                    { 34, "Lawful Good", "God of justice", "War", "Tyr" },
                    { 35, "Chaotic Evil", "Goddess of the sea", "Tempest", "Umberlee" },
                    { 36, "Neutral", "Goddess of trade", "Knowledge", "Waukeen" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Equipment Pack" },
                    { 2, "Potion" },
                    { 3, "Magic Scroll" },
                    { 4, "Mount" },
                    { 5, "Adventuring Gear" },
                    { 6, "Poison" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "BackgroundId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "The most commonly spoken language in the world. It was a language formed by the fusion of many cultures all slowly combining together over centuries.", "Common" },
                    { 2, null, "A complex language of Elves, with a great deal of subtlety and intricate grammar. It is very easy to say the wrong thing just by putting emphasis on the wrong syllable in a word. It is a common language among bards.", "Elvish" },
                    { 3, null, "The language of Dragons, Dragonborn, Kobold, and other related creatures. It is thought to be one of the oldest languages, and is often used in the study of magic. ", "Draconic" },
                    { 4, null, "The language of Gnomes developed alongside dwarvish, though segued into its own complex language as gnomes became more technically minded.", "Gnomish" },
                    { 5, null, "The language of Demons, Devils, and Monsters. Anyone who speaks it must have some amount of magical ability, as they are extremely difficult, if not impossible, to create some of the noises in the language with normal humanoid vocal cords.", "Infernal" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "BaseMovementSpeed", "Description", "FullDescription", "Name", "Size" },
                values: new object[,]
                {
                    { 1, 30, "Dwarves were raised from the earth in the elder days by a deity of the forge.", "Dwarves were raised from the earth in the elder days by a deity of the forge. Called by various names on different worlds—Moradin, Reorx, and others—that god gave dwarves an affinity for stone and metal and for living underground. The god also made them resilient like the mountains, with a life span of about 350 years.\r\n\r\nSquat and often bearded, the original dwarves carved cities and strongholds into mountainsides and under the earth. Their oldest legends tell of conflicts with the monsters of mountaintops and the Underdark, whether those monsters were towering giants or subterranean horrors. Inspired by those tales, dwarves of any culture often sing of valorous deeds—especially of the little overcoming the mighty.\r\n\r\nOn some worlds in the multiverse, the first settlements of dwarves were built in hills or mountains, and the families who trace their ancestry to those settlements call themselves hill dwarves or mountain dwarves, respectively. The Greyhawk and Dragonlance settings have such communities.", "Dwarf", "Medium" },
                    { 2, 30, "The elves’ curiosity led many of them to explore other planes of existence.", "Created by the god Corellon, the first elves could change their forms at will. They lost this ability when Corellon cursed them for plotting with the deity Lolth, who tried and failed to usurp Corellon’s dominion. When Lolth was cast into the Abyss, most elves renounced her and earned Corellon’s forgiveness, but that which Corellon had taken from them was lost forever.\r\n\r\nNo longer able to shape-shift at will, the elves retreated to the Feywild, where their sorrow was deepened by that plane’s influence. Over time, curiosity led many of them to explore other planes of existence, including worlds in the Material Plane.\r\n\r\nElves have pointed ears and lack facial and body hair. They live for around 750 years, and they don’t sleep but instead enter a trance when they need to rest. In that state, they remain aware of their surroundings while immersing themselves in memories and meditations.\r\n\r\nAn environment subtly transforms elves after they inhabit it for a millennium or more, and it grants them certain kinds of magic. Drow, high elves, and wood elves are examples of elves who have been transformed thus.", "Elf", "Medium" },
                    { 3, 30, "Halflings possess a brave and adventurous spirit that leads them on journeys of discovery.", "Cherished and guided by gods who value life, home, and hearth, halflings gravitate toward bucolic havens where family and community help shape their lives. That said, many halflings possess a brave and adventurous spirit that leads them on journeys of discovery, affording them the chance to explore a bigger world and make new friends along the way. Their size—similar to that of a human child—helps them pass through crowds unnoticed and slip through tight spaces.\r\n\r\nAnyone who has spent time around halflings, particularly halfling adventurers, has likely witnessed the storied “luck of the halflings” in action. When a halfling is in mortal danger, an unseen force seems to intervene on the halfling’s behalf. Many halflings believe in the power of luck, and they attribute their unusual gift to one or more of their benevolent gods, including Yondalla, Brandobaris, and Charmalaine. The same gift might contribute to their robust life spans (about 150 years).\r\n\r\nHalfling communities come in all varieties. For every sequestered shire tucked away in an unspoiled part of the world, there’s a crime syndicate like the Boromar Clan in the Eberron setting or a territorial mob of halflings like those in the Dark Sun setting.\r\n\r\nHalflings who prefer to live underground are sometimes called strongheart halflings or stouts. Nomadic halflings, as well as those who live among humans and other tall folk, are sometimes called lightfoot halflings or tallfellows.", "Halfling", "Small" },
                    { 4, 30, "Found throughout the multiverse, humans are as varied as they are numerous.", "Found throughout the multiverse, humans are as varied as they are numerous, and they endeavor to achieve as much as they can in the years they are given. Their ambition and resourcefulness are commended, respected, and feared on many worlds.\r\n\r\nHumans are as diverse in appearance as the people of Earth, and they have many gods. Scholars dispute the origin of humanity, but one of the earliest known human gatherings is said to have occurred in Sigil, the torus-shaped city at the center of the multiverse and the place where the Common language was born. From there, humans could have spread to every part of the multiverse, bringing the City of Doors’ cosmopolitanism with them.", "Human", "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "BaseNumberOfCasts", "CanTargetSelf", "CastingTime", "Concentration", "Description", "Duration", "Effects", "IndexName", "IsRecurring", "IsRecurringOnMove", "IsRitual", "MaterialComponent", "MaterialComponentDescription", "Name", "PlayerCharacterId", "Range", "School", "SomaticComponent", "SpellSlotLevel", "SubclassId", "UpcastEffect", "UpgradeLevels", "VerbalComponent" },
                values: new object[,]
                {
                    { 1, 1, false, "1 action", false, "You hurl a beam of crackling energy. Make a ranged spell attack against one creature or object in range. On a hit, the target takes 1d10 Force damage. Cantrip Upgrade. The spell creates two beams at level 5, three beams at level 11, and four beams at level 17. You can direct the beams at the same target or at different ones. Make a separate attack roll for each beam", "Instantaneous", "[{\"EffectType\":\"SpellAttackEffect\",\"Dice\":\"1d10\",\"IsAttackRoll\":true,\"DamageType\":\"force\",\"SavingThrowAttribute\":null,\"SavingThrowDC\":null,\"SavingThrowSuccessEffect\":null},{\"EffectType\":\"SpellCostEffect\",\"Action\":true,\"BonusAction\":false,\"Reaction\":false}]", "eldritch-blast", false, false, false, false, null, "Eldritch Blast", null, "120 feet", "Evocation", true, 0, null, null, "[5,11,17]", true },
                    { 2, 1, true, "1 bonus action", false, "A creature of your choice that you can see within range regains Hit Points equal to 2d4 plus your spellcasting ability modifier. Using a Higher-Level Spell Slot. The healing increases by 2d4 for each spell slot level above 1", "Instantaneous", "[{\"EffectType\":\"SpellHealingEffect\",\"Dice\":\"2d4\\u002B{sam}\",\"Amount\":0,\"IsTempHP\":false},{\"EffectType\":\"SpellCostEffect\",\"Action\":false,\"BonusAction\":true,\"Reaction\":false}]", "healing-word", false, false, false, false, null, "Healing Word", null, "60 feet", "Abjuration", false, 1, null, "2d4", null, true },
                    { 3, 1, false, "1 action", true, "Choose a Humanoid that you can see within range. The target must succeed on a Wisdom saving throw or have the Paralyzed condition for the duration. At the end of each of its turns, the target repeats the save, ending the spell on itself on a success. Using a Higher-Level Spell Slot. You can target one additional Humanoid for each spell slot level above 2.", "Concentration, up to 1 minute", "[{\"EffectType\":\"SpellAttackEffect\",\"Dice\":null,\"IsAttackRoll\":false,\"DamageType\":null,\"SavingThrowAttribute\":\"Wisdom\",\"SavingThrowDC\":-1,\"SavingThrowSuccessEffect\":\"negate-effect\"},{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":9,\"Name\":\"Paralyzed\",\"Description\":\"While you have the Paralyzed condition, you experience the following effects. Incapacitated. You have the Incapacitated condition. Speed 0. Your Speed is 0 and can\\u2019t increase. Saving Throws Affected. You automatically fail Strength and Dexterity saving throws. Attacks Affected. Attack rolls against you have Advantage. Automatic Critical Hits. Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you\",\"Effects\":[{\"EffectType\":\"ConditionEffect\",\"Condition\":{\"Id\":7,\"Name\":\"Incapacitated\",\"Description\":\"While you have the Incapacitated condition, you experience the following effects. Inactive. You can\\u2019t take any action, Bonus Action, or Reaction. No Concentration. Your Concentration is broken. Speechless. You can\\u2019t speak. Surprised. If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\",\"Effects\":[{\"EffectType\":\"ActionEconomyEffect\",\"NumberOfActions\":0,\"NumberOfBonusActions\":0,\"NumberOfReactions\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"No Concentration\",\"Description\":\"Your Concentration is broken.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Speechless\",\"Description\":\"You can\\u2019t speak.\"},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Surprised\",\"Description\":\"If you\\u2019re Incapacitated when you roll Initiative, you have Disadvantage on the roll.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"OtherCharacterEffect\",\"MovementSpeedModifier\":0,\"SpecialPointsModifier\":0,\"SpellSlotModifier\":{},\"HasAdvantageOrDisadvantageOnConcentrationSavingThrows\":null},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"strength\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttributeEffect\",\"TargetAttribute\":\"dexterity\",\"SetAttribute\":false,\"Modifier\":0,\"AddOrRemoveProficiencyInSavingThrows\":null,\"HasAdvantageOrDisadvantageOnSavingThrows\":null,\"HasAdvantageOrDisadvantageOnAbilityChecks\":null,\"AutomaticallySucceedsOnSavingThrows\":false},{\"EffectType\":\"AttackRollEffect\",\"HasAdvantageOrDisadvantage\":null,\"AttackersHaveAdvantageOrDisadvantage\":true,\"SpellAttackRollBonusModifier\":0,\"WeaponAttackRollBonusModifier\":0},{\"EffectType\":\"EsotericEffect\",\"Name\":\"Automatic Critical Hits\",\"Description\":\"Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.\"}]},\"SavingThrowAttribute\":null,\"SavingThrowDC\":null},{\"EffectType\":\"SpellCostEffect\",\"Action\":true,\"BonusAction\":false,\"Reaction\":false}]", "hold-person", true, false, false, true, "a straight piece of iron", "Hold Person", null, "60 feet", "Enchantment", true, 2, null, "bnoc+1", null, true },
                    { 4, 3, false, "1 action", false, "You hurl three fiery rays. You can hurl them at one target within range or at several. Make a ranged spell attack for each ray. On a hit, the target takes 2d6 Fire damage. Using a Higher-Level Spell Slot. You create one additional ray for each spell slot level above 2.", "Instantaneous", "[{\"EffectType\":\"SpellAttackEffect\",\"Dice\":\"2d6\",\"IsAttackRoll\":true,\"DamageType\":\"fire\",\"SavingThrowAttribute\":null,\"SavingThrowDC\":null,\"SavingThrowSuccessEffect\":null},{\"EffectType\":\"SpellCostEffect\",\"Action\":true,\"BonusAction\":false,\"Reaction\":false}]", "scorching-ray", false, false, false, false, null, "Scorching Ray", null, "120 feet", "Evocation", true, 2, null, "bnoc+1", null, true },
                    { 5, 1, false, "1 action", false, "A bright streak flashes from you to a point you choose within range and then blossoms with a low roar into a fiery explosion. Each creature in a 20-foot-radius Sphere centered on that point makes a Dexterity saving throw, taking 8d6 Fire damage on a failed save or half as much damage on a successful one. Flammable objects in the area that aren’t being worn or carried start burning.", "Instantaneous", "[{\"EffectType\":\"SpellAttackEffect\",\"Dice\":\"8d6\",\"IsAttackRoll\":false,\"DamageType\":\"fire\",\"SavingThrowAttribute\":\"dexterity\",\"SavingThrowDC\":15,\"SavingThrowSuccessEffect\":\"half-damage\"},{\"EffectType\":\"SpellCostEffect\",\"Action\":true,\"BonusAction\":false,\"Reaction\":false}]", "fireball", false, false, false, true, "a ball of bat guano and sulfur", "Fireball", null, "150 feet", "Evocation", true, 3, null, "1d6", null, true }
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Actions", "IndexName", "Name", "PlayerCharacterId" },
                values: new object[,]
                {
                    { 1, "[{\"Name\":\"Identify a substance\",\"Attribute\":\"intelligence\",\"DC\":15},{\"Name\":\"Start a fire\",\"Attribute\":\"intelligence\",\"DC\":15}]", "alchemists-supplies", "Alchemist's Supplies", null },
                    { 2, "[{\"Name\":\"Create a map\",\"Attribute\":\"wisdom\",\"DC\":15}]", "cartographers-tools", "Cartographer's Tools", null },
                    { 3, "[{\"Name\":\"Improve food\\u0027s flavor\",\"Attribute\":\"wisdom\",\"DC\":10},{\"Name\":\"Detect spoiled or poisoned food\",\"Attribute\":\"wisdom\",\"DC\":15}]", "cooks-utensils", "Cook's Utensils", null },
                    { 4, "[{\"Name\":\"Mimic 10 or fewer words of someone else\\u2019s handwriting\",\"Attribute\":\"dexterity\",\"DC\":15},{\"Name\":\"Duplicate a wax seal\",\"Attribute\":\"dexterity\",\"DC\":20}]", "forgery-kit", "Forgery Kit", null },
                    { 5, "[{\"Name\":\"Pick a lock\",\"Attribute\":\"dexterity\",\"DC\":15},{\"Name\":\"Disarm a trap\",\"Attribute\":\"dexterity\",\"DC\":15}]", "thieves-tools", "Thieves's Tools", null }
                });

            migrationBuilder.InsertData(
                table: "WeaponTypes",
                columns: new[] { "Id", "BaseCost", "BaseDamage", "DamageType", "IsMartial", "Name", "Properties", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "1d4", "bludgeoning", false, "Club", "[{\"Name\":\"Light\",\"ExtraInfo\":null}]", 2.0 },
                    { 2, 2, "1d4", "piercing", false, "Dagger", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null},{\"Name\":\"Light\",\"ExtraInfo\":null},{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"}]", 1.0 },
                    { 3, 2, "1d8", "bludgeoning", false, "Greatclub", "[{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 10.0 },
                    { 4, 5, "1d6", "slashing", false, "Handaxe", "[{\"Name\":\"Light\",\"ExtraInfo\":null},{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"}]", 2.0 },
                    { 5, 5, "1d6", "piercing", false, "Javelin", "[{\"Name\":\"Thrown\",\"ExtraInfo\":\"30/120\"}]", 2.0 },
                    { 6, 2, "1d4", "bludgeoning", false, "Light Hammer", "[{\"Name\":\"Light\",\"ExtraInfo\":null},{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"}]", 2.0 },
                    { 7, 5, "1d6", "bludgeoning", false, "Mace", "[]", 4.0 },
                    { 8, 2, "1d6", "bludgeoning", false, "Quarterstaff", "[{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d8\"}]", 4.0 },
                    { 9, 1, "1d4", "slashing", false, "Sickle", "[{\"Name\":\"Light\",\"ExtraInfo\":null}]", 2.0 },
                    { 10, 1, "1d6", "piercing", false, "Spear", "[{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"},{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d8\"}]", 3.0 },
                    { 11, 25, "1d8", "piercing", false, "Crossbow, Light", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"80/320\"},{\"Name\":\"Loading\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 5.0 },
                    { 12, 5, "1d4", "piercing", false, "Dart", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null},{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"}]", 0.25 },
                    { 13, 25, "1d6", "piercing", false, "Shortbow", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"80/320\"},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 2.0 },
                    { 14, 1, "1d4", "bludgeoning", false, "Sling", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"30/120\"}]", 0.0 },
                    { 15, 10, "1d8", "slashing", true, "Battleaxe", "[{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d10\"}]", 0.0 },
                    { 16, 10, "1d8", "bludgeoning", true, "Flail", "[]", 2.0 },
                    { 17, 20, "1d10", "slashing", true, "Glaive", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Reach\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 6.0 },
                    { 18, 30, "1d12", "slashing", true, "Greataxe", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 7.0 },
                    { 19, 50, "2d6", "slashing", true, "Greatsword", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 6.0 },
                    { 20, 20, "1d10", "slashing", true, "Halberd", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Reach\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 6.0 },
                    { 21, 10, "1d12", "piercing", true, "Lance", "[{\"Name\":\"Reach\",\"ExtraInfo\":null},{\"Name\":\"Special\",\"ExtraInfo\":null}]", 6.0 },
                    { 22, 15, "1d8", "slashing", true, "Longsword", "[{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d10\"}]", 3.0 },
                    { 23, 10, "2d6", "bludgeoning", true, "Maul", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 10.0 },
                    { 24, 15, "1d8", "piercing", true, "Morningstar", "[]", 4.0 },
                    { 25, 5, "1d10", "piercing", true, "Pike", "[{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Reach\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 18.0 },
                    { 26, 25, "1d8", "piercing", true, "Rapier", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null}]", 2.0 },
                    { 27, 25, "1d6", "slashing", true, "Scimitar", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null},{\"Name\":\"Light\",\"ExtraInfo\":null}]", 3.0 },
                    { 28, 10, "1d6", "piercing", true, "Shortsword", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null},{\"Name\":\"Light\",\"ExtraInfo\":null}]", 2.0 },
                    { 29, 5, "1d6", "piercing", true, "Trident", "[{\"Name\":\"Thrown\",\"ExtraInfo\":\"20/60\"},{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d8\"}]", 4.0 },
                    { 30, 5, "1d8", "piercing", true, "War Pick", "[]", 2.0 },
                    { 31, 15, "1d8", "bludgeoning", true, "Warhammer", "[{\"Name\":\"Versatile\",\"ExtraInfo\":\"1d10\"}]", 2.0 },
                    { 32, 2, "1d4", "slashing", true, "Whip", "[{\"Name\":\"Finesse\",\"ExtraInfo\":null},{\"Name\":\"Reach\",\"ExtraInfo\":null}]", 3.0 },
                    { 33, 10, "1", "piercing", true, "Blowgun", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"25/100\"},{\"Name\":\"Loading\",\"ExtraInfo\":null}]", 3.0 },
                    { 34, 75, "1d6", "piercing", true, "Crossbow, Hand", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"30/120\"},{\"Name\":\"Light\",\"ExtraInfo\":null},{\"Name\":\"Loading\",\"ExtraInfo\":null}]", 3.0 },
                    { 35, 50, "1d10", "piercing", true, "Crossbow, Heavy", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"100/400\"},{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Loading\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 18.0 },
                    { 36, 50, "1d8", "piercing", true, "Longbow", "[{\"Name\":\"Ammunition\",\"ExtraInfo\":\"150/600\"},{\"Name\":\"Heavy\",\"ExtraInfo\":null},{\"Name\":\"Two-Handed\",\"ExtraInfo\":null}]", 2.0 },
                    { 37, 1, "0", "none", true, "Net", "[{\"Name\":\"Special\",\"ExtraInfo\":null},{\"Name\":\"Thrown\",\"ExtraInfo\":\"5/15\"}]", 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Subraces",
                columns: new[] { "Id", "Description", "Name", "ParentRaceId" },
                values: new object[,]
                {
                    { 1, "Drow typically dwell in the Underdark and have been shaped by it. Some drow individuals and societies avoid the Underdark altogether yet carry its magic. In the Eberron setting, for example, drow dwell in rainforests and cyclopean ruins on the continent of Xen’drik.", "Drow", 2 },
                    { 2, "High elves have been infused with the magic of crossings between the Feywild and the Material Plane. On some worlds, high elves refer to themselves by other names. For example, they call themselves sun or moon elves in the Forgotten Realms setting, Silvanesti and Qualinesti in the Dragonlance setting, and Aereni in the Eberron setting", "High Elf", 2 },
                    { 3, "Wood elves carry the magic of primeval forests within themselves. They are known by many other names, including wild elves, green elves, and forest elves. Grugach are reclusive wood elves of the Greyhawk setting, while the Kagonesti and the Tairnadal are wood elves of the Dragonlance and Eberron settings, respectively.", "Wood Elf", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armors_ArmorTypeId",
                table: "Armors",
                column: "ArmorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_PlayerCharacterId",
                table: "Armors",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorSpell_SpellsId",
                table: "ArmorSpell",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorTrait_TraitsId",
                table: "ArmorTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorTypeClass_ClassesId",
                table: "ArmorTypeClass",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundEquipment_EquipmentId",
                table: "BackgroundEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundFeat_FeatsId",
                table: "BackgroundFeat",
                column: "FeatsId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundTool_ToolProficienciesId",
                table: "BackgroundTool",
                column: "ToolProficienciesId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundTrait_TraitsId",
                table: "BackgroundTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSpell_SpellsId",
                table: "ClassSpell",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTool_ToolProficienciesId",
                table: "ClassTool",
                column: "ToolProficienciesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTrait_TraitsId",
                table: "ClassTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWeaponType_WeaponProficienciesId",
                table: "ClassWeaponType",
                column: "WeaponProficienciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentCategoryId",
                table: "Equipment",
                column: "EquipmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PlayerCharacterId",
                table: "Equipment",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentTool_ToolsId",
                table: "EquipmentTool",
                column: "ToolsId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_PlayerCharacterId",
                table: "Feats",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageRace_RacesId",
                table: "LanguageRace",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_BackgroundId",
                table: "Languages",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_BackgroundId",
                table: "PlayerCharacters",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_ClassId",
                table: "PlayerCharacters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_RaceId",
                table: "PlayerCharacters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_SubclassId",
                table: "PlayerCharacters",
                column: "SubclassId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_SubraceId",
                table: "PlayerCharacters",
                column: "SubraceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTrait_TraitsId",
                table: "RaceTrait",
                column: "TraitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_PlayerCharacterId",
                table: "Spells",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SubclassId",
                table: "Spells",
                column: "SubclassId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellWeapon_WeaponsId",
                table: "SpellWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subclasses_ClassId",
                table: "Subclasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Subraces_ParentRaceId",
                table: "Subraces",
                column: "ParentRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_PlayerCharacterId",
                table: "Tools",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_PlayerCharacterId",
                table: "Traits",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_SubclassId",
                table: "Traits",
                column: "SubclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_SubraceId",
                table: "Traits",
                column: "SubraceId");

            migrationBuilder.CreateIndex(
                name: "IX_TraitWeapon_WeaponsId",
                table: "TraitWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ConditionId",
                table: "Weapons",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_PlayerCharacterId",
                table: "Weapons",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponTypeId",
                table: "Weapons",
                column: "WeaponTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorSpell");

            migrationBuilder.DropTable(
                name: "ArmorTrait");

            migrationBuilder.DropTable(
                name: "ArmorTypeClass");

            migrationBuilder.DropTable(
                name: "BackgroundEquipment");

            migrationBuilder.DropTable(
                name: "BackgroundFeat");

            migrationBuilder.DropTable(
                name: "BackgroundTool");

            migrationBuilder.DropTable(
                name: "BackgroundTrait");

            migrationBuilder.DropTable(
                name: "ClassSpell");

            migrationBuilder.DropTable(
                name: "ClassTool");

            migrationBuilder.DropTable(
                name: "ClassTrait");

            migrationBuilder.DropTable(
                name: "ClassWeaponType");

            migrationBuilder.DropTable(
                name: "Deities");

            migrationBuilder.DropTable(
                name: "EquipmentTool");

            migrationBuilder.DropTable(
                name: "LanguageRace");

            migrationBuilder.DropTable(
                name: "RaceTrait");

            migrationBuilder.DropTable(
                name: "SpellWeapon");

            migrationBuilder.DropTable(
                name: "TraitWeapon");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "ArmorTypes");

            migrationBuilder.DropTable(
                name: "EquipmentCategories");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "WeaponTypes");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Subclasses");

            migrationBuilder.DropTable(
                name: "Subraces");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
