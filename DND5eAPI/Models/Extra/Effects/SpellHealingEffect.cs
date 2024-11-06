namespace DND5eAPI.Models.Extra.Effects
{
    public class SpellHealingEffect : Effect
    {
        public override string EffectType => "SpellHealingEffect";
        public string? Dice { get; set; }
        public int? Amount { get; set; }
        public bool IsTempHP { get; set; }
        
        public SpellHealingEffect(string? dice = null, int amount = 0, bool isTempHP = false)
        {
            if (string.IsNullOrEmpty(dice) && amount == 0)
            {
                throw new ArgumentException("Dice and amount cannot be null or empty");
            }
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be lower than 0");
            }
            Dice = dice;
            Amount = amount;
            IsTempHP = isTempHP;
        }
    }
}
