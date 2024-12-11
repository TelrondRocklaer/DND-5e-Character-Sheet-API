namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class SkillProficiency : Proficiency
    {
        public string SkillName { get; set; }

        public SkillProficiency() { }

        public SkillProficiency(string attributeName, string skillName)
        {
            SkillName = new Attributes()[attributeName][skillName].Name;
        }
    }
}
