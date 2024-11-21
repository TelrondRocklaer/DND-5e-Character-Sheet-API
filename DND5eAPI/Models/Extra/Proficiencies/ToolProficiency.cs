using DND5eAPI.Data.SeedData;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ToolProficiency(string toolName) : Proficiency
    {
        public override string ProficiencyType => "ToolProficiency";

        public int ToolId { get; set; } = ToolsData.Tools.FirstOrDefault(t => t.Name == toolName)!.Id;
    }
}
