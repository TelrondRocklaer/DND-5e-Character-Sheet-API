using System.Text.Json;
using System.Text.Json.Serialization;
using DND5eAPI.Models.Extra.Effects;

namespace DND5eAPI.Utilities
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
                "ArmorClassEffect" => JsonSerializer.Deserialize<ArmorClassEffect>(root.GetRawText(), options),
                "AttackRollEffect" => JsonSerializer.Deserialize<AttackRollEffect>(root.GetRawText(), options),
                "AbilityCheckEffect" => JsonSerializer.Deserialize<AbilityCheckEffect>(root.GetRawText(), options),
                "OtherCharacterEffect" => JsonSerializer.Deserialize<OtherCharacterEffect>(root.GetRawText(), options),
                "SpellAttackEffect" => JsonSerializer.Deserialize<SpellAttackEffect>(root.GetRawText(), options),
                "SpellHealingEffect" => JsonSerializer.Deserialize<SpellHealingEffect>(root.GetRawText(), options),
                "ConditionEffect" => JsonSerializer.Deserialize<ConditionEffect>(root.GetRawText(), options),
                "ActionEconomyEffect" => JsonSerializer.Deserialize<ActionEconomyEffect>(root.GetRawText(), options),
                "EsotericEffect" => JsonSerializer.Deserialize<EsotericEffect>(root.GetRawText(), options),
                "ExtraWeaponDamageEffect" => JsonSerializer.Deserialize<ExtraWeaponDamageEffect>(root.GetRawText(), options),
                "SpellCostEffect" => JsonSerializer.Deserialize<SpellCostEffect>(root.GetRawText(), options),
                _ => throw new JsonException($"Unknown effect type: {type}")
            };
        }

        public override void Write(Utf8JsonWriter writer, Effect value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
