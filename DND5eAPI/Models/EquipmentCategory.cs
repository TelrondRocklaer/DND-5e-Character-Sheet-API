using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("EquipmentCategories")]
    public class EquipmentCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        [JsonIgnore]
        public ICollection<Equipment>? Equipment { get; set; }
    }
}
