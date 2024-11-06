namespace DND5eAPI.Models.Extra.Effects
{
    public class SkillEffect : Effect
    {
        public override string EffectType => "SkillEffect";
        public string AttributeName { get; set; }
        public string SkillName { get; set; }
        public bool? AddOrRemoveProficiency { get; set; } = null;
        public bool? HasAdvantageOrDisadvantageOnChecks { get; set; } = null;

        public SkillEffect(string attributeName, string skillName, bool? addOrRemoveProficiency = null, bool? hasAdvantageOrDisadvantageOnChecks = null)
        {
            if (!Attributes.Exists(attributeName) || new Attributes()[attributeName][skillName] == null)
            {
                throw new ArgumentException("Invalid attribute or skill name");
            }
            AttributeName = attributeName;
            SkillName = skillName;
            if (addOrRemoveProficiency == null && hasAdvantageOrDisadvantageOnChecks == null)
            {
                throw new ArgumentException("Must specify at least one of addOrRemoveProficiency or hasAdvantageOnChecks");
            }
            AddOrRemoveProficiency = addOrRemoveProficiency;
            HasAdvantageOrDisadvantageOnChecks = hasAdvantageOrDisadvantageOnChecks;
        }
    }
}
