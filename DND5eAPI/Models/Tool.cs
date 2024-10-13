using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models
{
    [Table("Tools")]
    public class Tool
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexName { get; set; }
        public string Description { get; set; }

        //
        public List<Background> Backgrounds { get; set; }
        public List<Class> Classes { get; set; }
    }
}
