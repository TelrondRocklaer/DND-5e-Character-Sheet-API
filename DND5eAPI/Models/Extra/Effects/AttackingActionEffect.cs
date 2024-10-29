using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models.Extra.Effects
{
    [NotMapped]
    public class AttackingActionEffect : Effect
    {
        public override string EffectType => "AttackingActionEffect";
        public string? Dice { get; set; }
        public bool IsAttackRoll { get; set; }
        public string? DamageType { get; set; }
        public string? SavingThrowAttribute { get; set; }
        public int? SavingThrowDC { get; set; }
        public string? SavingThrowSuccessEffect { get; set; } // half-damage, no-damage, negate-effect

        public AttackingActionEffect(string? dice, bool isAttackRoll, string damageType, string? savingThrowAttribute, int? savingThrowDC, string? savingThrowSuccessEffect)
        {
            if (isAttackRoll)
            {
                if (!DamageTypes.Exists(damageType))
                {
                    throw new ArgumentException("Attack action set incorrectly");
                }
            }
            if (string.IsNullOrEmpty(dice))
            {
                throw new ArgumentException("Dice cannot be null or empty");
            }
            if (!string.IsNullOrEmpty(savingThrowAttribute))
            {
                if (!Attributes.Exists(savingThrowAttribute) || savingThrowDC == null || string.IsNullOrEmpty(savingThrowSuccessEffect))
                {
                    throw new ArgumentException("Saving throw attributes mismatch");
                }
            }
            else
            {
                if (!(string.IsNullOrEmpty(savingThrowAttribute) && savingThrowDC == null && string.IsNullOrEmpty(savingThrowSuccessEffect)))
                {
                    throw new ArgumentException("Saving throw attributes mismatch");
                }
            }
            if (savingThrowSuccessEffect != null)
            {
                if (savingThrowSuccessEffect != "half-damage" && savingThrowSuccessEffect != "no-damage" && savingThrowSuccessEffect != "negate-effect")
                {
                    throw new ArgumentException("Saving throw success effect mismatch");
                }
            }
            if (damageType != null)
            {
                if (!DamageTypes.Exists(damageType))
                {
                    throw new ArgumentException("Invalid damage type");
                }
            }
            if (savingThrowAttribute != null)
            {
                if (!Attributes.Exists(savingThrowAttribute))
                {
                    throw new ArgumentException("Invalid saving throw attribute");
                }
            }
            Dice = dice;
            IsAttackRoll = isAttackRoll;
            DamageType = damageType;
            SavingThrowAttribute = savingThrowAttribute;
            SavingThrowDC = savingThrowDC;
            SavingThrowSuccessEffect = savingThrowSuccessEffect;
        }
    }
}
