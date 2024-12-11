namespace DND5eAPI.Models.Extra.Proficiencies
{
    public class SavingThrowProficiency : Proficiency
    {
        public string Ability { get; set; }

        public SavingThrowProficiency() { }

        public SavingThrowProficiency(string attributeName)
        {
            Ability = new Attributes()[attributeName].Name!;
        }
    }
}
