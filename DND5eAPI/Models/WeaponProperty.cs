using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("WeaponProperties")]
    public class WeaponProperty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        public List<WeaponType> WeaponTypes { get; set; }
    }
}
