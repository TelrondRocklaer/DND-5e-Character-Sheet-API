namespace DND5eAPI.Models.Extra.Effects
{
    public class ResistanceEffect : Effect
    {
        public override string EffectType => "ResistanceEffect";
        public string DamageType { get; set; }
        public bool IsVulnerable { get; set; }
        public bool IsResistant { get; set; }
        public bool IsImmune { get; set; } 

        public ResistanceEffect(string damageType, bool isVulnerable = false, bool isResistant = false, bool isImmune = false)
        {
            if (!DamageTypes.Exists(damageType))
            {
                throw new ArgumentException("Invalid damage type");
            }
            DamageType = damageType;
            if ((isVulnerable ? 1 : 0) + (isResistant ? 1 : 0) + (isImmune ? 1 : 0) == 1)
            {
                IsVulnerable = isVulnerable;
                IsResistant = isResistant;
                IsImmune = isImmune;
            }
            else
            {
                throw new ArgumentException("Exactly one of isVulnerable, isResistant, and isImmune must be true");
            }
        }
    }
}
