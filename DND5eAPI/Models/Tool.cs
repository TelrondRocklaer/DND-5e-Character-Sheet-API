using DND5eAPI.Models.Extra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Tools")]
    public class Tool
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public ICollection<Equipment> CraftableItems { get; set; }
        public ICollection<ToolAction> Actions { get; set; }

        //
        [JsonIgnore]
        public List<Background> Backgrounds { get; set; }
        [JsonIgnore]
        public List<Class> Classes { get; set; }
    }
}
