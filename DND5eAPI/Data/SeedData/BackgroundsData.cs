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

        public static Background[] Backgrounds =
        [
            Soldier
        ];
    }
}
