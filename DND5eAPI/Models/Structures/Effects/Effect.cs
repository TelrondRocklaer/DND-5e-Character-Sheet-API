using System.Text.Json.Serialization;

namespace DND5eAPI.Models.Structures.Effects
{
    [JsonConverter(typeof(EffectConverter))]
    public abstract class Effect
    {
        public abstract string EffectType { get; }
        public abstract void ApplyEffect(PlayerCharacter character);
    }
}
