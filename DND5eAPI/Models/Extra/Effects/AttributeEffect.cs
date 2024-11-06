namespace DND5eAPI.Models.Extra.Effects
{
    public class AttributeEffect : Effect
    {
        public override string EffectType => "AttributeEffect";
        public string TargetAttribute { get; set; }
        public bool SetAttribute { get; set; }
        public int Modifier { get; set; }
        public bool? AddOrRemoveProficiencyInSavingThrows { get; set; }
        public bool? HasAdvantageOrDisadvantageOnSavingThrows { get; set; }
        public bool? HasAdvantageOrDisadvantageOnAbilityChecks { get; set; }
        public bool? AutomaticallySucceedsOnSavingThrows { get; set; }

        public AttributeEffect(string targetAttribute, bool setAttribute = false, int modifier = 0, bool? addOrRemoveProficiencyInSavingThrows = null, 
            bool? hasAdvantageOrDisadvantageOnSavingThrows = null, bool? hasAdvantageOrDisadvantageOnAbilityChecks = null, bool? automaticallySucceedsOnSavingThrows = null)
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
            AddOrRemoveProficiencyInSavingThrows = addOrRemoveProficiencyInSavingThrows;
            HasAdvantageOrDisadvantageOnSavingThrows = hasAdvantageOrDisadvantageOnSavingThrows;
            HasAdvantageOrDisadvantageOnAbilityChecks = hasAdvantageOrDisadvantageOnAbilityChecks;
            AutomaticallySucceedsOnSavingThrows = automaticallySucceedsOnSavingThrows;
        }
    }
}
