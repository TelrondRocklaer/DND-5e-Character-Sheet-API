namespace DND5eAPI.Models.Extra.Effects
{
    public class AttributeEffect : Effect
    {
        public override string EffectType => "AttributeEffect";
        public string TargetAttribute { get; set; }
        public bool SetAttribute { get; set; }
        public int Modifier { get; set; }
        public bool IsProficientInSavingThrows { get; set; }
        public bool HasAdvantageOnSavingThrows { get; set; }
        public bool HasAdvantageOnAbilityChecks { get; set; }
        public bool HasDisadvantageOnSavingThrows { get; set; }
        public bool HasDisadvantageOnAbilityChecks { get; set; }

        public AttributeEffect(string targetAttribute, bool setAttribute = false, int modifier = 0,
            bool isProficientInSavingThrows = false, bool hasAdvantageOnSavingThrows = false,
            bool hasAdvantageOnAbilityChecks = false, bool hasDisadvantageOnSavingThrows = false,
            bool hasDisadvantageOnAbilityChecks = false)
        {
            if (!Attributes.Exists(targetAttribute))
            {
                throw new ArgumentException("Invalid attribute name");
            }
            TargetAttribute = targetAttribute;
            if (setAttribute && modifier <= 0)
            {
                throw new ArgumentException("Modifier must be set above 0 if setting attribute");
            }
            SetAttribute = setAttribute;
            Modifier = modifier;
            if (hasAdvantageOnAbilityChecks && hasDisadvantageOnAbilityChecks)
            {
                throw new ArgumentException("Cannot have advantage and disadvantage on ability checks");
            }
            if (hasAdvantageOnSavingThrows && hasDisadvantageOnSavingThrows)
            {
                throw new ArgumentException("Cannot have advantage and disadvantage on saving throws");
            }
            IsProficientInSavingThrows = isProficientInSavingThrows;
            HasAdvantageOnSavingThrows = hasAdvantageOnSavingThrows;
            HasAdvantageOnAbilityChecks = hasAdvantageOnAbilityChecks;
            HasDisadvantageOnSavingThrows = hasDisadvantageOnSavingThrows;
            HasDisadvantageOnAbilityChecks = hasDisadvantageOnAbilityChecks;
        }
    }
}
