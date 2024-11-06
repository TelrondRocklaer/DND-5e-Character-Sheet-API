namespace DND5eAPI.Models.Extra.Effects
{
    public class AttackRollEffect : Effect
    {
        public override string EffectType => "AttackRollEffect";

        public bool? HasAdvantageOrDisadvantage { get; set; }
        public bool? AttackersHaveAdvantageOrDisadvantage { get; set; }
        public int SpellAttackRollBonusModifier { get; set; }
        public int WeaponAttackRollBonusModifier { get; set; }

        public AttackRollEffect(bool? hasAdvantageOrDisadvantage = null, bool? attackersHaveAdvantageOrDisadvantage = null, int spellAttackRollBonusModifier = 0, int weaponAttackRollBonusModifier = 0)
        {
            SpellAttackRollBonusModifier = spellAttackRollBonusModifier;
            WeaponAttackRollBonusModifier = weaponAttackRollBonusModifier;
            if (hasAdvantageOrDisadvantage == null && attackersHaveAdvantageOrDisadvantage == null)
            {
                throw new ArgumentNullException("Parameters hasAdvantageOrDisadvantage and attackersHaveAdvantageOrDisadvantage cannot be null");
            }
            HasAdvantageOrDisadvantage = hasAdvantageOrDisadvantage;
            AttackersHaveAdvantageOrDisadvantage = attackersHaveAdvantageOrDisadvantage;
        }
    }
}
