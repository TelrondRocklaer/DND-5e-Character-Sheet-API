using DND5eAPI.Models;

namespace DND5eAPI.Data.SeedData
{
    public static class RacesData
    {
        public static readonly Race Dwarf = new()
        {
            Id = 1,
            Name = "Dwarf",
            Description = "Dwarves were raised from the earth in the elder days by a deity of the forge.",
            FullDescription = "Dwarves were raised from the earth in the elder days by a deity of the forge. Called by various names on different worlds—Moradin, Reorx, and others—that god gave dwarves an affinity for stone and metal and for living underground. The god also made them resilient like the mountains, with a life span of about 350 years.\r\n\r\nSquat and often bearded, the original dwarves carved cities and strongholds into mountainsides and under the earth. Their oldest legends tell of conflicts with the monsters of mountaintops and the Underdark, whether those monsters were towering giants or subterranean horrors. Inspired by those tales, dwarves of any culture often sing of valorous deeds—especially of the little overcoming the mighty.\r\n\r\nOn some worlds in the multiverse, the first settlements of dwarves were built in hills or mountains, and the families who trace their ancestry to those settlements call themselves hill dwarves or mountain dwarves, respectively. The Greyhawk and Dragonlance settings have such communities.",
            BaseMovementSpeed = 30,
            Languages = [LanguagesData.Common],
            Size = "Medium"
        };

        public static readonly Race Elf = new()
        {
            Id = 2,
            Name = "Elf",
            Description = "The elves’ curiosity led many of them to explore other planes of existence.",
            FullDescription = "Created by the god Corellon, the first elves could change their forms at will. They lost this ability when Corellon cursed them for plotting with the deity Lolth, who tried and failed to usurp Corellon’s dominion. When Lolth was cast into the Abyss, most elves renounced her and earned Corellon’s forgiveness, but that which Corellon had taken from them was lost forever.\r\n\r\nNo longer able to shape-shift at will, the elves retreated to the Feywild, where their sorrow was deepened by that plane’s influence. Over time, curiosity led many of them to explore other planes of existence, including worlds in the Material Plane.\r\n\r\nElves have pointed ears and lack facial and body hair. They live for around 750 years, and they don’t sleep but instead enter a trance when they need to rest. In that state, they remain aware of their surroundings while immersing themselves in memories and meditations.\r\n\r\nAn environment subtly transforms elves after they inhabit it for a millennium or more, and it grants them certain kinds of magic. Drow, high elves, and wood elves are examples of elves who have been transformed thus.",
            BaseMovementSpeed = 30,
            Languages = [LanguagesData.Common, LanguagesData.Elvish],
            Size = "Medium"
        };

        public static readonly Race Halfling = new()
        {
            Id = 3,
            Name = "Halfling",
            Description = "Halflings possess a brave and adventurous spirit that leads them on journeys of discovery.",
            FullDescription = "Cherished and guided by gods who value life, home, and hearth, halflings gravitate toward bucolic havens where family and community help shape their lives. That said, many halflings possess a brave and adventurous spirit that leads them on journeys of discovery, affording them the chance to explore a bigger world and make new friends along the way. Their size—similar to that of a human child—helps them pass through crowds unnoticed and slip through tight spaces.\r\n\r\nAnyone who has spent time around halflings, particularly halfling adventurers, has likely witnessed the storied “luck of the halflings” in action. When a halfling is in mortal danger, an unseen force seems to intervene on the halfling’s behalf. Many halflings believe in the power of luck, and they attribute their unusual gift to one or more of their benevolent gods, including Yondalla, Brandobaris, and Charmalaine. The same gift might contribute to their robust life spans (about 150 years).\r\n\r\nHalfling communities come in all varieties. For every sequestered shire tucked away in an unspoiled part of the world, there’s a crime syndicate like the Boromar Clan in the Eberron setting or a territorial mob of halflings like those in the Dark Sun setting.\r\n\r\nHalflings who prefer to live underground are sometimes called strongheart halflings or stouts. Nomadic halflings, as well as those who live among humans and other tall folk, are sometimes called lightfoot halflings or tallfellows.",
            BaseMovementSpeed = 30,
            Languages = [LanguagesData.Common, LanguagesData.Gnomish],
            Size = "Small"
        };

        public static readonly Race Human = new()
        {
            Id = 4,
            Name = "Human",
            Description = "Found throughout the multiverse, humans are as varied as they are numerous.",
            FullDescription = "Found throughout the multiverse, humans are as varied as they are numerous, and they endeavor to achieve as much as they can in the years they are given. Their ambition and resourcefulness are commended, respected, and feared on many worlds.\r\n\r\nHumans are as diverse in appearance as the people of Earth, and they have many gods. Scholars dispute the origin of humanity, but one of the earliest known human gatherings is said to have occurred in Sigil, the torus-shaped city at the center of the multiverse and the place where the Common language was born. From there, humans could have spread to every part of the multiverse, bringing the City of Doors’ cosmopolitanism with them.",
            BaseMovementSpeed = 30,
            Languages = [LanguagesData.Common],
            Size = "Medium"
        };

        public static Race[] Races = [
            Dwarf, 
            Elf, 
            Halfling, 
            Human
        ];
    }
}
