namespace DND5eAPI.Models.Extra.Effects
{
    public class ArmorClassEffect : Effect
    {
        public override string EffectType => "ArmorClassEffect";
        public bool SetArmorClass { get; set; }
        public string ArmorClassModifier { get; set; }

        public ArmorClassEffect(bool setArmorClass = false, string armorClassModifier = "0")
        {
            SetArmorClass = setArmorClass;
            ArmorClassModifier = armorClassModifier;
        }
    }
}
