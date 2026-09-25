using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public class LegoHarryPotterYears5To7 : IGame
    {
        public string Title { get; } = "Lego Harry Potter: Years 5-7";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "Z9BFAD", Description = "Fast dig" },
                new CheatCode { Code = "74YKR7", Description = "Score 2x" },
                new CheatCode { Code = "UWCQHB", Description = "Score 4x" },
                new CheatCode { Code = "XK9ANE", Description = "Score 6x" },
                new CheatCode { Code = "HUFV2H", Description = "Score 8x" },
                new CheatCode { Code = "H8X69Y", Description = "Score 10x" },
                new CheatCode { Code = "T7PVVN", Description = "Christmas" },
                new CheatCode { Code = "ZEX7MV", Description = "Fall rescue" },
                new CheatCode { Code = "AUC8EH", Description = "Carrot wands" },
                new CheatCode { Code = "J9U6Z9", Description = "Extra hearts" },
                new CheatCode { Code = "QQWC6B", Description = "Invincibility" },
                new CheatCode { Code = "BMEU6X", Description = "Super strength" },
                new CheatCode { Code = "H27KGC", Description = "Character Studs" },
                new CheatCode { Code = "7AD7HE", Description = "Red brick detector" },
                new CheatCode { Code = "84QNQN", Description = "Gold brick detector" },
                new CheatCode { Code = "2FLY6B", Description = "Collect ghost studs" },
                new CheatCode { Code = "TTMC6D", Description = "Hogwarts crest detector" },
                new CheatCode { Code = "HA79V8", Description = "Character Token Detector" },
            };
    }
}
