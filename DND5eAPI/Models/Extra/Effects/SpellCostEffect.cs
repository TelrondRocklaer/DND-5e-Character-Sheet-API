namespace DND5eAPI.Models.Extra.Effects
{
    public class SpellCostEffect : Effect
    {
        public bool Action { get; set; }
        public bool BonusAction { get; set; }
        public bool Reaction { get; set; }

        public SpellCostEffect() { }

        public SpellCostEffect(bool action = false, bool bonusAction = false, bool reaction = false)
        {
            Action = action;
            BonusAction = bonusAction;
            Reaction = reaction;
        }
    }
}
