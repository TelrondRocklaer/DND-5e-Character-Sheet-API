namespace DND5eAPI.Models.Extra.Effects
{
    public class ActionEconomyEffect : Effect
    {
        public override string EffectType => "ActionEconomyEffect";
        public int? NumberOfActions { get; set; }
        public int? NumberOfBonusActions { get; set; }
        public int? NumberOfReactions { get; set; }

        public ActionEconomyEffect(int? numberOfActions = null, int? numberOfBonusActions = null, int? numberOfReactions = null)
        {
            NumberOfActions = numberOfActions;
            NumberOfBonusActions = numberOfBonusActions;
            NumberOfReactions = numberOfReactions;
        }
    }
}
