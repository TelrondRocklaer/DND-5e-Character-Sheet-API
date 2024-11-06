using System.ComponentModel.DataAnnotations.Schema;

namespace DND5eAPI.Models.Extra.Effects
{
    [NotMapped]
    public class SpellAttackEffect : Effect
    {
        public override string EffectType => "SpellAttackEffect";
        public string? Dice { get; set; }
        public bool IsAttackRoll { get; set; }
        public string? DamageType { get; set; }
        public string? SavingThrowAttribute { get; set; }
        public int? SavingThrowDC { get; set; }
        public string? SavingThrowSuccessEffect { get; set; } // half-damage, no-damage, negate-effect

        public SpellAttackEffect(string? dice = null, bool isAttackRoll = false, string? damageType = null, string? savingThrowAttribute = null, int? savingThrowDC = null, string? savingThrowSuccessEffect = null)
        {
            if (isAttackRoll)
            {
                if (!DamageTypes.Exists(damageType!))
                {
                    throw new ArgumentException("Attack action set incorrectly");
                }
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
            if (damageType != null)
            {
                if (damageType.Contains(','))
                {
                    string[] damageTypes = damageType.Split(',');
                    foreach (string type in damageTypes)
                    {
                        if (!DamageTypes.Exists(type))
                        {
                            throw new ArgumentException("Invalid damage type");
                        }
                    }
                }
            }
            if (savingThrowAttribute != null)
            {
                if (!Attributes.Exists(savingThrowAttribute))
                {
                    throw new ArgumentException("Invalid saving throw attribute");
                }
            }
            if (savingThrowDC != null)
            {
                if (savingThrowDC < -1)
                {
                    throw new ArgumentException("Saving throw DC cannot be lower than 0");
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
