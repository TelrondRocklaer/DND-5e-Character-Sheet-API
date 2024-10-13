using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("EquipmentCategories")]
    public class EquipmentCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        public List<Equipment> Equipment { get; set; }
    }
}
