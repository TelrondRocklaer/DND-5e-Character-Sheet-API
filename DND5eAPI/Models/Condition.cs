using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Conditions")]
    public class Condition
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Effects { get; set; }

        //
        public List<Spell> Spells { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}
