using DND5eAPI.Models.Extra.Proficiencies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Backgrounds")]
    public class Background
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Proficiency> Proficiencies { get; set; }
        public uint StartingGold { get; set; }

        //
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<Feat> Feats { get; set; }
        public ICollection<Trait> Traits { get; set; }
    }
}
