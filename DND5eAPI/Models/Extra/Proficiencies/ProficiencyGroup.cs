namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ProficiencyGroup(string groupName) : Proficiency
    {
        public override string ProficiencyType => "ProficiencyGroup";

        public string ProficiencyGroupName { get; set; } = (new string[] { "Simple Weapons", "Martial Weapons", "Armor", "Tool", "Skill", "Saving Throws" }.Contains(groupName)) ? groupName : throw new Exception("Group name is not valid");
    }
}
