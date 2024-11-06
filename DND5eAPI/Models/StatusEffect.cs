using DND5eAPI.Models.Extra.Effects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("StatusEffects")]
    public class StatusEffect
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Effect> Effects { get; set; }
    }
}
