using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class LanguagesData
    {
        public static readonly Language Common = new() 
        { 
            Id = 1,
            Name = "Common", 
            Description = "The most commonly spoken language in the world. It was a language formed by the fusion of many cultures all slowly combining together over centuries." 
        };

        public static readonly Language Elvish = new() 
        { 
            Id = 2,
            Name = "Elvish", 
            Description = "A complex language of Elves, with a great deal of subtlety and intricate grammar. It is very easy to say the wrong thing just by putting emphasis on the wrong syllable in a word. It is a common language among bards."
        };

        public static readonly Language Draconic = new() 
        {
            Id = 3,
            Name = "Draconic", 
            Description = "The language of Dragons, Dragonborn, Kobold, and other related creatures. It is thought to be one of the oldest languages, and is often used in the study of magic. " 
        };

        public static readonly Language Gnomish = new() 
        {
            Id = 4,
            Name = "Gnomish", 
            Description = "The language of Gnomes developed alongside dwarvish, though segued into its own complex language as gnomes became more technically minded." 
        };

        public static readonly Language Infernal = new() 
        {
            Id = 5,
            Name = "Infernal", 
            Description = "The language of Demons, Devils, and Monsters. Anyone who speaks it must have some amount of magical ability, as they are extremely difficult, if not impossible, to create some of the noises in the language with normal humanoid vocal cords." 
        };

        public static Language[] Languages = [
            Common, 
            Elvish, 
            Draconic, 
            Gnomish, 
            Infernal
        ];
    }
}
