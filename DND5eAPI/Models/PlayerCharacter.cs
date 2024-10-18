using static DND5eAPI.Models.CharacterData;

namespace DND5eAPI.Models
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public int MovementSpeed { get; set; }
        public bool WearsArmor { get; set; }
        public bool IsShieldEquipped { get; set; }
        public Attributes Attributes { get; set; }
        public Resistances Resistances { get; set; }
        public bool HasAdvantageOnConcentrationSavingThrows { get; set; }
        public bool HasDisadvantageOnConcentrationSavingThrows { get; set; }

        public int ProficiencyBonus
        {
            get
            {
                return 1 + (int)Math.Ceiling((double)(Level / 4));
            }
        }

        public int PassivePerception
        {
            get
            {
                return 10 + Attributes["wisdom"].Modifier + (Attributes["wisdom"]["perception"].IsProficient ? ProficiencyBonus : 0);
            }
        }

        //
        public Race Race { get; set; }
        public Class Class { get; set; }
        public Background Background { get; set; }
        public List<Feat> Feats { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Tool> ToolProficiencies { get; set; }
        public List<Equipment> Inventory { get; set; }
        public List<Armor> EquipedArmor { get; set; }
        public List<Weapon> EquipedWeapons { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}
