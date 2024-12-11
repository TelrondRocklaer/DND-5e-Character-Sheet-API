using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ToolProficiency : Proficiency
    {
        public int ToolId { get; set; }

        public ToolProficiency() { }

        public ToolProficiency(string toolName)
        {
            ToolId = ToolsData.Tools.FirstOrDefault(t => t.Name == toolName)!.Id;
        }
    }
}
