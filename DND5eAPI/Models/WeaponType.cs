using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using DND5eAPI.Models.Extra;

namespace DND5eAPI.Models
{
    [Table("WeaponTypes")]
    public class WeaponType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMartial { get; set; }
        public string BaseDamage { get; set; }
        public string DamageType { get; set; }
        public int BaseCost { get; set; }
        public double Weight { get; set; }
        public ICollection<WeaponProperty> Properties { get; set; }

        //    
        [JsonIgnore]
        public ICollection<Weapon>? Weapons { get; set; }
        [JsonIgnore]
        public ICollection<Class>? Classes { get; set; }
    }
}
