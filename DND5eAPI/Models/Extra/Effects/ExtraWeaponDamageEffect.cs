namespace DND5eAPI.Models.Extra.Effects
{
    public class ExtraWeaponDamageEffect : Effect
    {
        public override string EffectType => "ExtraWeaponDamageEffect";

        public string DamageType { get; set; }
        public string? DamageDie { get; set; }
        public int? DamageBonus { get; set; }

        public ExtraWeaponDamageEffect(string damageType, string? damageDie = null, int? damageBonus = null)
        {
            if (!DamageTypes.Exists(damageType))
            {
                throw new ArgumentException("Invalid damage type");
            }
            DamageType = damageType;
            DamageDie = damageDie;
            if (damageBonus != null && damageBonus < 0)
            {
                throw new ArgumentException("Damage bonus must be a positive number");
            }
            DamageBonus = damageBonus;
        }
    }
}
