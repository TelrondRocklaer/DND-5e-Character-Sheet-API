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
        public string SkillProficiencies { get; set; }
        public int StartingGold { get; set; }

        //
        public List<Tool> ToolProficiencies { get; set; }
        public List<Language> Languages { get; set; }
        public List<Feat> Feats { get; set; }
        public List<Trait> Traits { get; set; }
    }
}
