namespace DND5eAPI.Models.Extra.Effects
{
    public class EsotericEffect : Effect
    {
        public override string EffectType => "EsotericEffect";
        public string Name { get; set; }
        public string Description { get; set; }

        public EsotericEffect(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
