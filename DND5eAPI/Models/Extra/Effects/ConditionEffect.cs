namespace DND5eAPI.Models.Extra.Effects
{
    public class ConditionEffect : Effect
    {
        public override string EffectType => "ConditionEffect";

        public Condition Condition { get; set; }

        public ConditionEffect(Condition condition)
        {
            Condition = condition;
        }
    }
}
