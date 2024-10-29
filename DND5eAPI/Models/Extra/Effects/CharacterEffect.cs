namespace DND5eAPI.Models.Extra.Effects
{
    public class CharacterEffect : Effect
    {
        public override string EffectType => "CharacterEffect";
        public bool SetArmorClass { get; set; }
        public int ArmorClassModifier { get; set; }
        public int MovementSpeedModifier { get; set; }
        public int SpecialPointsModifier { get; set; }
        public (int level, int modifier) SpellSlotModifier { get; set; }
        public int SpellAttackRollBonusModifier { get; set; }
        public int WeaponAttackRollBonusModifier { get; set; }
        public bool HasAdvantageOnConcentrationSavingThrows { get; set; }
        public bool HasDisadvantageOnConcentrationSavingThrows { get; set; }
    
        public CharacterEffect(bool setArmorClass = false, int armorClassModifier = 0, int movementSpeedModifier = 0, 
            int specialPointsModifier = 0, (int level, int modifier)? spellSlotModifier = null, int spellAttackRollBonusModifier = 0, 
            int weaponAttackRollBonusModifier = 0, bool hasAdvantageOnConcentrationSavingThrows = false, bool hasDisadvantageOnConcentrationSavingThrows = false)
        {
            SetArmorClass = setArmorClass;
            ArmorClassModifier = armorClassModifier;
            MovementSpeedModifier = movementSpeedModifier;
            SpecialPointsModifier = specialPointsModifier;
            if (spellSlotModifier == null)
            {
                SpellSlotModifier = (0, 0);
            }
            else
            {
                if (spellSlotModifier.Value.level < 0 || spellSlotModifier.Value.level > 9)
                {
                    throw new ArgumentException("Spell slot level must be between 0 and 9");
                }
                if (spellSlotModifier.Value.modifier < -4 || spellSlotModifier.Value.modifier > 4 || spellSlotModifier.Value.modifier == 0)
                {
                    throw new ArgumentException("Spell slot modifier must be between -4 and 4 and not equal to 0");
                }
                SpellSlotModifier = ((int level, int modifier))spellSlotModifier;
            }       
            SpellAttackRollBonusModifier = spellAttackRollBonusModifier;
            WeaponAttackRollBonusModifier = weaponAttackRollBonusModifier;
            if (hasAdvantageOnConcentrationSavingThrows && hasDisadvantageOnConcentrationSavingThrows)
            {
                throw new ArgumentException("Cannot have advantage and disadvantage on concentration saving throws at the same time");
            }
            HasAdvantageOnConcentrationSavingThrows = hasAdvantageOnConcentrationSavingThrows;
            HasDisadvantageOnConcentrationSavingThrows = hasDisadvantageOnConcentrationSavingThrows;
        }
    }
}
