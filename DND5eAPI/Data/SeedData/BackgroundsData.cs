using DND5eAPI.Models;
using DND5eAPI.Models.Extra.Proficiencies;

namespace DND5eAPI.Data.SeedData
{
    public static class BackgroundsData
    {
        public static readonly Background Soldier = new()
        {
            Id = 1,
            Name = "Soldier",
            Description = "You began training for war as soon as you reached adulthood and carry precious few memories of life before you took up arms. Battle is in your blood. Sometimes you catch yourself reflexively performing the basic fighting exercises you learned first. Eventually, you put that training to use on the battlefield, protecting the realm by waging war",
            Proficiencies =
            [
                new SkillProficiency("Strength", "Athletics"),
                new SkillProficiency("Charisma", "Intimidation")
                // TODO: Add Tools distinction (utility, game...)
                // new ToolProficiency("Choose one kind of Gaming Set")
            ],
            StartingGold = 14
        };

        public static readonly Background Sage = new()
        {
            Id = 2,
            Name = "Sage",
            Description = "You spent your formative years traveling between manors and monasteries, performing various odd jobs and services in exchange for access to their libraries. You whiled away many a long evening studying books and scrolls, learning the lore of the multiverse—even the rudiments of magic—and your mind yearns for more.",
            Proficiencies =
            [
                new SkillProficiency("Intelligence", "Arcana"),
                new SkillProficiency("Intelligence", "History"),
                new ToolProficiency("Calligrapher's Supplies")
            ],
            Equipment =
            [
                EquipmentData.Parchment
            ],
            StartingGold = 8
        };

        public static Background[] Backgrounds =
        [
            Soldier,
            Sage
        ];
    }
}
