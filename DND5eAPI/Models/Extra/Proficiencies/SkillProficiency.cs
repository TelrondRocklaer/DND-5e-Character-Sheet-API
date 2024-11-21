namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class SkillProficiency(string attributeName, string skillName) : Proficiency
    {
        public override string ProficiencyType => "SkillProficiency";

        public string SkillName { get; set; } = new Attributes()[attributeName][skillName].Name;
    }
}
