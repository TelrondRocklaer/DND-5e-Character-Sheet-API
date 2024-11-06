namespace DND5eAPI.Models.Extra.Effects
{
    public class AbilityCheckEffect : Effect
    {
        public override string EffectType => "AbilityCheckEffect";

        public bool? HasAdvantageOrDisadvantage { get; set; }

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
