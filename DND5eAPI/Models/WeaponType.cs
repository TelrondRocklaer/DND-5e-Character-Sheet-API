using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("WeaponTypes")]
    public class WeaponType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        public List<WeaponProperty> Properties { get; set; } 
        public List<Weapon> Weapons { get; set; }
        public List<Class> Classes { get; set; }
    }
}
