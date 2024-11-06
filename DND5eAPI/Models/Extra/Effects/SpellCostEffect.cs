namespace DND5eAPI.Models.Extra.Effects
{
    public class SpellCostEffect : Effect
    {
        public override string EffectType => "SpellCostEffect";

        public bool Action { get; set; }
        public bool BonusAction { get; set; }
        public bool Reaction { get; set; }

        public SpellCostEffect(bool action = false, bool bonusAction = false, bool reaction = false)
        {
            Action = action;
            BonusAction = bonusAction;
            Reaction = reaction;
        }
    }
}
