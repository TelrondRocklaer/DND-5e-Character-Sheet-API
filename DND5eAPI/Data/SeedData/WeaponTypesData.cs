using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class WeaponTypesData
    {
        public static readonly WeaponType Club = new()
        { 
            Id = 1, 
            Name = "Club",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "bludgeoning",
            BaseCost = 1,
            Weight = 2,
            Properties = [WeaponPropertiesData.Light]
        };

        public static readonly WeaponType Dagger = new()
        {
            Id = 2,
            Name = "Dagger",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "piercing",
            BaseCost = 2,
            Weight = 1,
            Properties = [WeaponPropertiesData.Finesse, WeaponPropertiesData.Light, WeaponPropertiesData.ThrownE20G60]
        };

        public static readonly WeaponType Greatclub = new()
        {
            Id = 3,
            Name = "Greatclub",
            IsMartial = false,
            BaseDamage = "1d8",
            DamageType = "bludgeoning",
            BaseCost = 2,
            Weight = 10,
            Properties = [WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Handaxe = new()
        {
            Id = 4,
            Name = "Handaxe",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "slashing",
            BaseCost = 5,
            Weight = 2,
            Properties = [WeaponPropertiesData.Light, WeaponPropertiesData.ThrownE20G60]
        };

        public static readonly WeaponType Javelin = new()
        {
            Id = 5,
            Name = "Javelin",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 5,
            Weight = 2,
            Properties = [WeaponPropertiesData.ThrownE30G120]
        };

        public static readonly WeaponType LightHammer = new()
        {
            Id = 6,
            Name = "Light Hammer",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "bludgeoning",
            BaseCost = 2,
            Weight = 2,
            Properties = [WeaponPropertiesData.Light, WeaponPropertiesData.ThrownE20G60]
        };

        public static readonly WeaponType Mace = new()
        {
            Id = 7,
            Name = "Mace",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "bludgeoning",
            BaseCost = 5,
            Weight = 4,
            Properties = []
        };

        public static readonly WeaponType Quarterstaff = new()
        {
            Id = 8,
            Name = "Quarterstaff",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "bludgeoning",
            BaseCost = 2,
            Weight = 4,
            Properties = [WeaponPropertiesData.VersatileD8]
        };

        public static readonly WeaponType Sickle = new()
        {
            Id = 9,
            Name = "Sickle",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "slashing",
            BaseCost = 1,
            Weight = 2,
            Properties = [WeaponPropertiesData.Light]
        };

        public static readonly WeaponType Spear = new()
        {
            Id = 10,
            Name = "Spear",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 1,
            Weight = 3,
            Properties = [WeaponPropertiesData.ThrownE20G60, WeaponPropertiesData.VersatileD8]
        };

        public static readonly WeaponType CrossbowLight = new()
        {
            Id = 11,
            Name = "Crossbow, Light",
            IsMartial = false,
            BaseDamage = "1d8",
            DamageType = "piercing",
            BaseCost = 25,
            Weight = 5,
            Properties = [WeaponPropertiesData.AmmunitionE80G320, WeaponPropertiesData.Loading, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Dart = new()
        {
            Id = 12,
            Name = "Dart",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "piercing",
            BaseCost = 5,
            Weight = 0.25,
            Properties = [WeaponPropertiesData.Finesse, WeaponPropertiesData.ThrownE20G60]
        };

        public static readonly WeaponType Shortbow = new()
        {
            Id = 13,
            Name = "Shortbow",
            IsMartial = false,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 25,
            Weight = 2,
            Properties = [WeaponPropertiesData.AmmunitionE80G320, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Sling = new()
        {
            Id = 14,
            Name = "Sling",
            IsMartial = false,
            BaseDamage = "1d4",
            DamageType = "bludgeoning",
            BaseCost = 1,
            Weight = 0,
            Properties = [WeaponPropertiesData.AmmunitionE30G120]
        };

        public static readonly WeaponType Battleaxe = new()
        {
            Id = 15,
            Name = "Battleaxe",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "slashing",
            BaseCost = 10,
            Weight = 0,
            Properties = [WeaponPropertiesData.VersatileD10]
        };

        public static readonly WeaponType Flail = new()
        {
            Id = 16,
            Name = "Flail",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "bludgeoning",
            BaseCost = 10,
            Weight = 2,
            Properties = []
        };

        public static readonly WeaponType Glaive = new()
        {
            Id = 17,
            Name = "Glaive",
            IsMartial = true,
            BaseDamage = "1d10",
            DamageType = "slashing",
            BaseCost = 20,
            Weight = 6,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.Reach, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Greataxe = new()
        {
            Id = 18,
            Name = "Greataxe",
            IsMartial = true,
            BaseDamage = "1d12",
            DamageType = "slashing",
            BaseCost = 30,
            Weight = 7,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Greatsword = new()
        {
            Id = 19,
            Name = "Greatsword",
            IsMartial = true,
            BaseDamage = "2d6",
            DamageType = "slashing",
            BaseCost = 50,
            Weight = 6,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Halberd = new()
        {
            Id = 20,
            Name = "Halberd",
            IsMartial = true,
            BaseDamage = "1d10",
            DamageType = "slashing",
            BaseCost = 20,
            Weight = 6,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.Reach, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Lance = new()
        {
            Id = 21,
            Name = "Lance",
            IsMartial = true,
            BaseDamage = "1d12",
            DamageType = "piercing",
            BaseCost = 10,
            Weight = 6,
            Properties = [WeaponPropertiesData.Reach, WeaponPropertiesData.Special]
        };

        public static readonly WeaponType Longsword = new()
        {
            Id = 22,
            Name = "Longsword",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "slashing",
            BaseCost = 15,
            Weight = 3,
            Properties = [WeaponPropertiesData.VersatileD10]
        };

        public static readonly WeaponType Maul = new()
        {
            Id = 23,
            Name = "Maul",
            IsMartial = true,
            BaseDamage = "2d6",
            DamageType = "bludgeoning",
            BaseCost = 10,
            Weight = 10,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Morningstar = new()
        {
            Id = 24,
            Name = "Morningstar",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "piercing",
            BaseCost = 15,
            Weight = 4,
            Properties = []
        };

        public static readonly WeaponType Pike = new()
        {
            Id = 25,
            Name = "Pike",
            IsMartial = true,
            BaseDamage = "1d10",
            DamageType = "piercing",
            BaseCost = 5,
            Weight = 18,
            Properties = [WeaponPropertiesData.Heavy, WeaponPropertiesData.Reach, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Rapier = new()
        {
            Id = 26,
            Name = "Rapier",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "piercing",
            BaseCost = 25,
            Weight = 2,
            Properties = [WeaponPropertiesData.Finesse]
        };

        public static readonly WeaponType Scimitar = new()
        {
            Id = 27,
            Name = "Scimitar",
            IsMartial = true,
            BaseDamage = "1d6",
            DamageType = "slashing",
            BaseCost = 25,
            Weight = 3,
            Properties = [WeaponPropertiesData.Finesse, WeaponPropertiesData.Light]
        };

        public static readonly WeaponType Shortsword = new()
        {
            Id = 28,
            Name = "Shortsword",
            IsMartial = true,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 10,
            Weight = 2,
            Properties = [WeaponPropertiesData.Finesse, WeaponPropertiesData.Light]
        };

        public static readonly WeaponType Trident = new()
        {
            Id = 29,
            Name = "Trident",
            IsMartial = true,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 5,
            Weight = 4,
            Properties = [WeaponPropertiesData.ThrownE20G60, WeaponPropertiesData.VersatileD8]
        };

        public static readonly WeaponType WarPick = new()
        {
            Id = 30,
            Name = "War Pick",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "piercing",
            BaseCost = 5,
            Weight = 2,
            Properties = []
        };

        public static readonly WeaponType Warhammer = new()
        {
            Id = 31,
            Name = "Warhammer",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "bludgeoning",
            BaseCost = 15,
            Weight = 2,
            Properties = [WeaponPropertiesData.VersatileD10]
        };

        public static readonly WeaponType Whip = new()
        {
            Id = 32,
            Name = "Whip",
            IsMartial = true,
            BaseDamage = "1d4",
            DamageType = "slashing",
            BaseCost = 2,
            Weight = 3,
            Properties = [WeaponPropertiesData.Finesse, WeaponPropertiesData.Reach]
        };

        public static readonly WeaponType Blowgun = new()
        {
            Id = 33,
            Name = "Blowgun",
            IsMartial = true,
            BaseDamage = "1",
            DamageType = "piercing",
            BaseCost = 10,
            Weight = 3,
            Properties = [WeaponPropertiesData.AmmunitionE25G100, WeaponPropertiesData.Loading]
        };

        public static readonly WeaponType CrossbowHand = new()
        {
            Id = 34,
            Name = "Crossbow, Hand",
            IsMartial = true,
            BaseDamage = "1d6",
            DamageType = "piercing",
            BaseCost = 75,
            Weight = 3,
            Properties = [WeaponPropertiesData.AmmunitionE30G120, WeaponPropertiesData.Light, WeaponPropertiesData.Loading]
        };

        public static readonly WeaponType CrossbowHeavy = new()
        {
            Id = 35,
            Name = "Crossbow, Heavy",
            IsMartial = true,
            BaseDamage = "1d10",
            DamageType = "piercing",
            BaseCost = 50,
            Weight = 18,
            Properties = [WeaponPropertiesData.AmmunitionE100G400, WeaponPropertiesData.Heavy, WeaponPropertiesData.Loading, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Longbow = new()
        {
            Id = 36,
            Name = "Longbow",
            IsMartial = true,
            BaseDamage = "1d8",
            DamageType = "piercing",
            BaseCost = 50,
            Weight = 2,
            Properties = [WeaponPropertiesData.AmmunitionE150G600, WeaponPropertiesData.Heavy, WeaponPropertiesData.TwoHanded]
        };

        public static readonly WeaponType Net = new()
        {
            Id = 37,
            Name = "Net",
            IsMartial = true,
            BaseDamage = "0",
            DamageType = "none",
            BaseCost = 1,
            Weight = 3,
            Properties = [WeaponPropertiesData.Special, WeaponPropertiesData.ThrownE5G15]
        };

        public static WeaponType[] WeaponTypes = [
            Club,
            Dagger,
            Greatclub,
            Handaxe,
            Javelin,
            LightHammer,
            Mace,
            Quarterstaff,
            Sickle,
            Spear,
            CrossbowLight,
            Dart,
            Shortbow,
            Sling,
            Battleaxe,
            Flail,
            Glaive,
            Greataxe,
            Greatsword,
            Halberd,
            Lance,
            Longsword,
            Maul,
            Morningstar,
            Pike,
            Rapier,
            Scimitar,
            Shortsword,
            Trident,
            WarPick,
            Warhammer,
            Whip,
            Blowgun,
            CrossbowHand,
            CrossbowHeavy,
            Longbow,
            Net
        ];
    }
}
