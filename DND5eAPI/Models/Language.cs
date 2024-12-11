using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models
{
    [Table("Languages")]
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //
        [JsonIgnore]
        public ICollection<Race>? Races { get; set; }
    }
}
