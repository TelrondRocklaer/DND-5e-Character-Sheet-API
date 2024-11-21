namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class SavingThrowProficiency(string attributeName) : Proficiency
    {
        public override string ProficiencyType => "SavingThrowProficiency";

        public string Ability { get; set; } = new Attributes()[attributeName].Name!;
    }
}
