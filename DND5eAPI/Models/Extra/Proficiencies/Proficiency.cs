using DND5eAPI.Utilities;
using Newtonsoft.Json;

namespace DND5eAPI.Models.Extra.Proficiencies
{
    [JsonConverter(typeof(ProficiencyConverter))]
    public abstract class Proficiency
    {
        public abstract string ProficiencyType { get; }
    }
}
