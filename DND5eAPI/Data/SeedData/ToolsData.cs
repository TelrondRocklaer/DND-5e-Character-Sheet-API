using DND5eAPI.Models;
using DND5eAPI.Models.Extra;

namespace DND5eAPI.Data.SeedData
{
    public static class ToolsData
    {
        public static readonly Tool AlchemistsSupplies = new()
        {
            Id = 1,
            Name = "Alchemist's Supplies",
            IndexName = "alchemists-supplies",
            CraftableItems = [],
            Actions = [new ToolAction("Identify a substance", "intelligence", 15), 
                       new ToolAction("Start a fire", "intelligence", 15)]
        };

        public static readonly Tool CartographerTools = new()
        {
            Id = 2,
            Name = "Cartographer's Tools",
            IndexName = "cartographers-tools",
            CraftableItems = [],
            Actions = [new ToolAction("Create a map", "wisdom", 15)]
        };

        public static readonly Tool CooksUtensils = new()
        {
            Id = 3,
            Name = "Cook's Utensils",
            IndexName = "cooks-utensils",
            CraftableItems = [],
            Actions = [new ToolAction("Improve food's flavor", "wisdom", 10),
                       new ToolAction("Detect spoiled or poisoned food", "wisdom", 15)]
        };

        public static readonly Tool ForgeryKit = new()
        {
            Id = 4,
            Name = "Forgery Kit",
            IndexName = "forgery-kit",
            CraftableItems = [],
            Actions = [new ToolAction("Mimic 10 or fewer words of someone else’s handwriting", "dexterity", 15),
                       new ToolAction("Duplicate a wax seal", "dexterity", 20)]
        };

        public static readonly Tool ThievesTools = new()
        {
            Id = 5,
            Name = "Thieves's Tools",
            IndexName = "thieves-tools",
            CraftableItems = [],
            Actions = [new ToolAction("Pick a lock", "dexterity", 15),
                       new ToolAction("Disarm a trap", "dexterity", 15)]
        };

        public static Tool[] Tools = [
            AlchemistsSupplies, 
            CartographerTools, 
            CooksUtensils, 
            ForgeryKit, 
            ThievesTools
        ];
    }
}
