namespace DND5eAPI.Models.Extra.Effects
{
    public class EsotericEffect : Effect
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public EsotericEffect() { }

        public EsotericEffect(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
