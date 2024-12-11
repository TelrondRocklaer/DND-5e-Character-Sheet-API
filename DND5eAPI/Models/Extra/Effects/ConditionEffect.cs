namespace DND5eAPI.Models.Extra.Effects
{
    public class ConditionEffect : Effect
    {
        public Condition Condition { get; set; }

        public string? SavingThrowAttribute { get; set; }
        public int? SavingThrowDC { get; set; }

        public ConditionEffect() { }

        public ConditionEffect(Condition condition, string? savingThrowAttribute = null, int? savingThrowDC = null)
        {
            Condition = condition;
            if (!string.IsNullOrEmpty(savingThrowAttribute) && !Attributes.Exists(savingThrowAttribute))
            {
                throw new ArgumentException("Invalid saving throw attribute");
            }
            SavingThrowAttribute = savingThrowAttribute;
            SavingThrowDC = savingThrowDC;
        }
    }
}
