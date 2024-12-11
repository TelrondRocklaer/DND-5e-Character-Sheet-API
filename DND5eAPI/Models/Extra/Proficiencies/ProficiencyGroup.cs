namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class ProficiencyGroup : Proficiency
    {
        public string ProficiencyGroupName { get; set; }

        public ProficiencyGroup() { }

        public ProficiencyGroup(string groupName)
        {
            ProficiencyGroupName = (new string[] { "Simple Weapons", "Martial Weapons", "Armor", "Tool", "Skill", "Saving Throws" }.Contains(groupName)) ? groupName : throw new Exception("Group name is not valid");
        }
    }
}
