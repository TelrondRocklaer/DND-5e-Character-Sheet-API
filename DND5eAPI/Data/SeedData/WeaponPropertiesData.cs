using DND5eAPI.Models.Extra;

namespace DND5eAPI.Data.SeedData
{
    public static class WeaponPropertiesData
    {
        public static readonly WeaponProperty AmmunitionE25G100 = new() { Name = "Ammunition", ExtraInfo = "25/100" };
        public static readonly WeaponProperty AmmunitionE30G120 = new() { Name = "Ammunition", ExtraInfo = "30/120" };
        public static readonly WeaponProperty AmmunitionE80G320 = new() { Name = "Ammunition", ExtraInfo = "80/320" };
        public static readonly WeaponProperty AmmunitionE100G400 = new() { Name = "Ammunition", ExtraInfo = "100/400" };
        public static readonly WeaponProperty AmmunitionE150G600 = new() { Name = "Ammunition", ExtraInfo = "150/600" };
        public static readonly WeaponProperty Finesse = new() { Name = "Finesse" };
        public static readonly WeaponProperty Heavy = new() { Name = "Heavy" };
        public static readonly WeaponProperty Light = new() { Name = "Light" };
        public static readonly WeaponProperty Loading = new() { Name = "Loading" };
        public static readonly WeaponProperty Range = new() { Name = "Range" };
        public static readonly WeaponProperty Reach = new() { Name = "Reach" };
        public static readonly WeaponProperty Special = new() { Name = "Special" };
        public static readonly WeaponProperty ThrownE5G15 = new() { Name = "Thrown", ExtraInfo = "5/15" };
        public static readonly WeaponProperty ThrownE20G60 = new() { Name = "Thrown", ExtraInfo = "20/60" };
        public static readonly WeaponProperty ThrownE30G120 = new() { Name = "Thrown", ExtraInfo = "30/120" };
        public static readonly WeaponProperty TwoHanded = new() { Name = "Two-Handed" };
        public static readonly WeaponProperty VersatileD8 = new() { Name = "Versatile", ExtraInfo = "1d8" };
        public static readonly WeaponProperty VersatileD10 = new() { Name = "Versatile", ExtraInfo = "1d10" };

        public static WeaponProperty[] WeaponProperties = [
            AmmunitionE25G100, 
            AmmunitionE30G120, 
            AmmunitionE80G320, 
            AmmunitionE100G400, 
            AmmunitionE150G600, 
            Finesse, 
            Heavy, 
            Light, 
            Loading, 
            Range, 
            Reach, 
            Special, 
            ThrownE5G15, 
            ThrownE20G60, 
            ThrownE30G120, 
            TwoHanded, 
            VersatileD8, 
            VersatileD10
        ];
    }
}
