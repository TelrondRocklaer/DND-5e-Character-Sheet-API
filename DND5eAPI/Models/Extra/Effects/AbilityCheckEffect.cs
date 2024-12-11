namespace DND5eAPI.Models.Extra.Effects
{
    public class AbilityCheckEffect : Effect
    {
        public bool? HasAdvantageOrDisadvantage { get; set; }
        public AbilityCheckEffect() { }

        public AbilityCheckEffect(bool? hasAdvantageOrDisadvantage = null)
        {
            if (hasAdvantageOrDisadvantage == null)
            {
                throw new ArgumentNullException("Parameter cannot be null");
            }
            HasAdvantageOrDisadvantage = hasAdvantageOrDisadvantage;
        }
    }
}
