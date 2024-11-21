using DND5eAPI.Models.Extra.Proficiencies;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DND5eAPI.Utilities
{
    public class ProficiencyConverter : JsonConverter<Proficiency>
    {
        public override Proficiency? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;
            var type = root.GetProperty("ProficiencyType").GetString();
            return type switch
            {
                "ArmorProficiency" => JsonSerializer.Deserialize<ArmorProficiency>(root.GetRawText(), options),
                "WeaponProficiency" => JsonSerializer.Deserialize<WeaponProficiency>(root.GetRawText(), options),
                "ToolProficiency" => JsonSerializer.Deserialize<ToolProficiency>(root.GetRawText(), options),
                "SkillProficiency" => JsonSerializer.Deserialize<SkillProficiency>(root.GetRawText(), options),
                "SavingThrowProficiency" => JsonSerializer.Deserialize<SavingThrowProficiency>(root.GetRawText(), options),
                "ProficiencyGroup" => JsonSerializer.Deserialize<ProficiencyGroup>(root.GetRawText(), options),
                _ => throw new JsonException($"Unknown proficiency type: {type}")
            };
        }

        public override void Write(Utf8JsonWriter writer, Proficiency value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
