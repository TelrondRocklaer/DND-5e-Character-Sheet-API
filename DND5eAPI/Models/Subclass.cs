using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Subclasses")]
    public class Subclass
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        public ICollection<Trait> Traits { get; set; }
        public ICollection<Spell> Spells { get; set; }
    }
}
