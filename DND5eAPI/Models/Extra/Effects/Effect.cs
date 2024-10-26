using System.Text.Json.Serialization;
using DND5eAPI.Utilities;

namespace DND5eAPI.Models.Extra.Effects
{
    [JsonConverter(typeof(EffectConverter))]
    public abstract class Effect
    {
        public abstract string EffectType { get; }
        public abstract void ApplyEffect(PlayerCharacter character);
    }
}
