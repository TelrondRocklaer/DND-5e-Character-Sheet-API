using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DND5eAPI.Models.Structures.Effects
{
    public class EffectConverter : JsonConverter<Effect>
    {
        public override Effect? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;
            var type = root.GetProperty("EffectType").GetString();
            return type switch
            {
                "ResistanceEffect" => JsonSerializer.Deserialize<ResistanceEffect>(root.GetRawText(), options),
                "AttributeEffect" => JsonSerializer.Deserialize<AttributeEffect>(root.GetRawText(), options),
                "SkillEffect" => JsonSerializer.Deserialize<SkillEffect>(root.GetRawText(), options),
                _ => throw new JsonException($"Unknown effect type: {type}")
            };
        }

        public override void Write(Utf8JsonWriter writer, Effect value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
