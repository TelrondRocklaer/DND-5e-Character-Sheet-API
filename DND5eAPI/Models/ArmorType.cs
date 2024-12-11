using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("ArmorTypes")]
    public class ArmorType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //
        [JsonIgnore]
        public ICollection<Armor>? Armors { get; set; }
        [JsonIgnore]
        public ICollection<Class>? Classes { get; set; }
    }
}
