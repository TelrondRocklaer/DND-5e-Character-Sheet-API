namespace DND5eAPI.Models.Extra.Effects
{
    public class OtherCharacterEffect : Effect
    {
        public int MovementSpeedModifier { get; set; }
        public int SpecialPointsModifier { get; set; }
        public (int level, int modifier) SpellSlotModifier { get; set; }
        public bool? HasAdvantageOrDisadvantageOnConcentrationSavingThrows { get; set; }

        public OtherCharacterEffect() { }

        public OtherCharacterEffect(int movementSpeedModifier = 0, int specialPointsModifier = 0, (int level, int modifier)? spellSlotModifier = null,
            bool? hasAdvantageOrDisadvantageOnConcentrationSavingThrows = null)
        {
            MovementSpeedModifier = movementSpeedModifier;
            SpecialPointsModifier = specialPointsModifier;
            if (spellSlotModifier == null)
            {
                SpellSlotModifier = (0, 0);
            }
            else
            {
                if (spellSlotModifier.Value.level < 0 || spellSlotModifier.Value.level > 9)
                {
                    throw new ArgumentException("Spell slot level must be between 0 and 9");
                }
                if (spellSlotModifier.Value.modifier < -4 || spellSlotModifier.Value.modifier > 4 || spellSlotModifier.Value.modifier == 0)
                {
                    throw new ArgumentException("Spell slot modifier must be between -4 and 4 and not equal to 0");
                }
                SpellSlotModifier = ((int level, int modifier))spellSlotModifier;
            }
            HasAdvantageOrDisadvantageOnConcentrationSavingThrows = hasAdvantageOrDisadvantageOnConcentrationSavingThrows;
        }
    }
}
