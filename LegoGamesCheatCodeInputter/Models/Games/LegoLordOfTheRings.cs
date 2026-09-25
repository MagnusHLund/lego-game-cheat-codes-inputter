using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoLordOfTheRings : IGame
    {
        public string Title { get; } = "Lego Lord of the Rings";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "73HJP6", Description = "Hama" },
                new CheatCode { Code = "U47AOG", Description = "Eomer" },
                new CheatCode { Code = "C19F3A", Description = "Madril" },
                new CheatCode { Code = "AVJII1", Description = "Gamling" },
                new CheatCode { Code = "PJB6MV", Description = "Shagrat" },
                new CheatCode { Code = "1F5YH2", Description = "Studs x2" },
                new CheatCode { Code = "RJV4KB", Description = "Denethor" },
                new CheatCode { Code = "7B4VWH", Description = "Galadriel" },
                new CheatCode { Code = "UE5Z7H", Description = "Berserker" },
                new CheatCode { Code = "MX26RJ", Description = "Disguises" },
                new CheatCode { Code = "D49TXY", Description = "Poo Studs" },
                new CheatCode { Code = "R7XKDH", Description = "Easterling" },
                new CheatCode { Code = "A2LU58", Description = "Fast Build" },
                new CheatCode { Code = "WS68P2", Description = "Fall Rescue" },
                new CheatCode { Code = "GD35HC", Description = "8-bit Music" },
                new CheatCode { Code = "EY4K32", Description = "Quest Finder" },
                new CheatCode { Code = "T1JM4R", Description = "Action Assist" },
                new CheatCode { Code = "C7FJ7B", Description = "Attract Studs" },
                new CheatCode { Code = "J4337V", Description = "Bilbo Baggins" },
                new CheatCode { Code = "LG5GI7", Description = "Gondor Ranger" },
                new CheatCode { Code = "2MCRDN", Description = "Mithril Hearts" },
                new CheatCode { Code = "F3H14H", Description = "Boss Disguises" },
                new CheatCode { Code = "C2A58D", Description = "Lothlorien Elf" },
                new CheatCode { Code = "F4M7FC", Description = "Mouth Of Sauron" },
                new CheatCode { Code = "QL28WB", Description = "Lurtz (Newborn)" },
                new CheatCode { Code = "PR3V4K", Description = "Character Studs" },
                new CheatCode { Code = "BU95CB", Description = "Grima Wormtongue" },
                new CheatCode { Code = "IH7E58", Description = "King Of The Dead" },
                new CheatCode { Code = "HTYADU", Description = "Boromir (Captain)" },
                new CheatCode { Code = "H5L6N6", Description = "Regenerate Hearts" },
                new CheatCode { Code = "5LV6EB", Description = "Radagast The Brown" },
                new CheatCode { Code = "A9FB4Q", Description = "Elrond (Second Age)" },
                new CheatCode { Code = "A24TVJ", Description = "Minikit Chest Finder" },
                new CheatCode { Code = "B72D7E", Description = "Mithril Brick Finder" },
                new CheatCode { Code = "LYQU1F", Description = "Ringwraith (Twilight)" },
            };
    }
}
