namespace DND5eAPI.Models.Structures.Effects
{
    public class ResistanceEffect : Effect
    {
        public string DamageType { get; set; }
        public bool IsVulnerable { get; set; }
        public bool IsResistant { get; set; }
        public bool IsImmune { get; set; }

        public override string EffectType => "ResistanceEffect";

        public ResistanceEffect(string damageType, bool isVulnerable = false, bool isResistant = false, bool isImmune = false)
        {
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

        public override void ApplyEffect(PlayerCharacter character)
        {
            var damageType = character.Resistances[DamageType.ToLower()];
            if (damageType != null)
            {
                damageType.IsVulnerable = IsVulnerable ? true : damageType.IsVulnerable;
                damageType.IsResistant = IsResistant ? true : damageType.IsResistant;
                damageType.IsImmune = IsImmune ? true : damageType.IsImmune;
            }
        }
    }
}
