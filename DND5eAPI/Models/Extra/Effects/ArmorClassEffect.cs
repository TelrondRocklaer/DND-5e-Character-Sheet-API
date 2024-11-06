namespace DND5eAPI.Models.Extra.Effects
{
    public class ArmorClassEffect : Effect
    {
        public override string EffectType => "ArmorClassEffect";
        public bool SetArmorClass { get; set; }
        public int ArmorClassModifier { get; set; }

        public ArmorClassEffect(bool setArmorClass = false, int armorClassModifier = 0)
        {
            if (setArmorClass && armorClassModifier < 0)
            {
                throw new ArgumentException("Armor class modifier must be greater than or equal to 0");
            }
            SetArmorClass = setArmorClass;
            ArmorClassModifier = armorClassModifier;
        }
    }
}
