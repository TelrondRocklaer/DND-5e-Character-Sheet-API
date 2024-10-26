namespace DND5eAPI.Models.Extra.Effects
{
    public class SkillEffect : Effect
    {
        public string AttributeName { get; set; }
        public string SkillName { get; set; }
        public bool IsProficient { get; set; } = false;
        public bool HasAdvantageOnChecks { get; set; } = false;
        public bool HasDisadvantageOnChecks { get; set; } = false;

        public override string EffectType => "SkillEffect";

        public SkillEffect(string attributeName, string skillName, bool isProficient = false,
            bool hasAdvantageOnChecks = false, bool hasDisadvantageOnChecks = false)
        {
            AttributeName = attributeName;
            SkillName = skillName;
            IsProficient = isProficient;
            HasAdvantageOnChecks = hasAdvantageOnChecks;
            HasDisadvantageOnChecks = hasDisadvantageOnChecks;
        }

        public override void ApplyEffect(PlayerCharacter character)
        {
            var skill = character.Attributes[AttributeName.ToLower()][SkillName.ToLower()];
            if (IsProficient)
            {
                skill.IsProficient = true;
            }

            if (HasAdvantageOnChecks)
            {
                skill.HasAdvantageOnChecks = true;
            }

            if (HasDisadvantageOnChecks)
            {
                skill.HasDisadvantageOnChecks = true;
            }
        }
    }
}
