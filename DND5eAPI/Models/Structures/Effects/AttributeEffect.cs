namespace DND5eAPI.Models.Structures.Effects
{
    public class AttributeEffect : Effect
    {
        public string TargetAttribute { get; set; }
        public bool SetAttribute { get; set; }
        public int Modifier { get; set; }
        public bool IsProficientInSavingThrows { get; set; }
        public bool HasAdvantageOnSavingThrows { get; set; }
        public bool HasAdvantageOnAbilityChecks { get; set; }
        public bool HasDisadvantageOnSavingThrows { get; set; }
        public bool HasDisadvantageOnAbilityChecks { get; set; }

        public override string EffectType => "AttributeEffect";

        public AttributeEffect(string targetAttribute, bool setAttribute = false, int modifier = 0,
            bool isProficientInSavingThrows = false, bool hasAdvantageOnSavingThrows = false,
            bool hasAdvantageOnAbilityChecks = false, bool hasDisadvantageOnSavingThrows = false,
            bool hasDisadvantageOnAbilityChecks = false)
        {
            TargetAttribute = targetAttribute;
            SetAttribute = setAttribute;
            Modifier = modifier;
            IsProficientInSavingThrows = isProficientInSavingThrows;
            HasAdvantageOnSavingThrows = hasAdvantageOnSavingThrows;
            HasAdvantageOnAbilityChecks = hasAdvantageOnAbilityChecks;
            HasDisadvantageOnSavingThrows = hasDisadvantageOnSavingThrows;
            HasDisadvantageOnAbilityChecks = hasDisadvantageOnAbilityChecks;
        }

        public override void ApplyEffect(PlayerCharacter character)
        {
            var attribute = character.Attributes[TargetAttribute.ToLower()];
            if (SetAttribute)
            {
                if (attribute.Value < Modifier)
                {
                    attribute.Value = Modifier;
                }
            }
            else if (Modifier != 0)
            {
                attribute.Value += Modifier;
            }

            if (IsProficientInSavingThrows)
            {
                attribute.IsProficientInSavingThrows = true;
            }

            if (HasAdvantageOnSavingThrows)
            {
                attribute.HasAdvantageOnSavingThrows = true;
            }

            if (HasAdvantageOnAbilityChecks)
            {
                attribute.HasAdvantageOnAbilityChecks = true;
            }

            if (HasDisadvantageOnSavingThrows)
            {
                attribute.HasDisadvantageOnSavingThrows = true;
            }

            if (HasDisadvantageOnAbilityChecks)
            {
                attribute.HasDisadvantageOnAbilityChecks = true;
            }
        }
    }
}
