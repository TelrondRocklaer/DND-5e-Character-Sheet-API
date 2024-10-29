namespace DND5eAPI.Models.Extra.Effects
{
    public class SkillEffect : Effect
    {
        public override string EffectType => "SkillEffect";
        public string AttributeName { get; set; }
        public string SkillName { get; set; }
        public bool IsProficient { get; set; } = false;
        public bool HasAdvantageOnChecks { get; set; } = false;
        public bool HasDisadvantageOnChecks { get; set; } = false;

        public SkillEffect(string attributeName, string skillName, bool isProficient = false,
            bool hasAdvantageOnChecks = false, bool hasDisadvantageOnChecks = false)
        {
            if (!Attributes.Exists(attributeName) || new Attributes()[attributeName][skillName] == null)
            {
                throw new ArgumentException("Invalid attribute or skill name");
            }
            AttributeName = attributeName;
            SkillName = skillName;
            IsProficient = isProficient;
            if (hasAdvantageOnChecks && hasDisadvantageOnChecks)
            {
                throw new ArgumentException("Cannot have both advantage and disadvantage on checks");
            }
            HasAdvantageOnChecks = hasAdvantageOnChecks;
            HasDisadvantageOnChecks = hasDisadvantageOnChecks;
        }
    }
}
