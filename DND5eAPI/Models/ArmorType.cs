using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("ArmorTypes")]
    public class ArmorType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        public List<Armor> Armors { get; set; }
        public List<Class> Classes { get; set; }
    }
}
