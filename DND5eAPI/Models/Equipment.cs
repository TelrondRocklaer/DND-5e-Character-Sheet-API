using DND5eAPI.Models.Extra.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Equipment")]
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public int EquipmentCategoryId { get; set; }
        public ICollection<Effect>? Effects { get; set; }

        //
        [ForeignKey("EquipmentCategoryId")]
        public EquipmentCategory EquipmentCategory { get; set; }
        [JsonIgnore]
        public ICollection<Background>? Backgrounds { get; set; }
        [JsonIgnore]
        public ICollection<Tool>? Tools { get; set; }
    }
}
