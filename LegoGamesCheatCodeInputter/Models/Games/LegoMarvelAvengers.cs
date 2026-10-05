using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoMarvelAvengers : AbstractGame
    {
        public override string Title { get; } = "Lego Marvel Avengers";

        public override IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "2K8QCG", Description = "A-Bomb" },
                new CheatCode { Code = "3ZDB2W", Description = "Amadeus Cho" },
                new CheatCode { Code = "8HG9HC", Description = "Bengal" },
                new CheatCode { Code = "MJNFAJ", Description = "Butterball" },
                new CheatCode { Code = "93NNGB", Description = "Chase" },
                new CheatCode { Code = "BTS8M6", Description = "Cottonmouth" },
                new CheatCode { Code = "ZNCK2S", Description = "Count Nefaria" },
                new CheatCode { Code = "UNECSY", Description = "Diamondback" },
                new CheatCode { Code = "5MZ73E", Description = "Fast Build" },
                new CheatCode { Code = "WU9YBF", Description = "Finesse" },
                new CheatCode { Code = "RABVV7", Description = "Firebird" },
                new CheatCode { Code = "4AKZ4G", Description = "Ironman (Mk 33 - Silver Centurian)" },
                new CheatCode { Code = "M562MB", Description = "Mantis" },
                new CheatCode { Code = "JYJAFX", Description = "Minikit Detector" },
                new CheatCode { Code = "N4YANB", Description = "Quasar" },
                new CheatCode { Code = "MFUPE7", Description = "Skaar" },
                new CheatCode { Code = "K66TQP", Description = "Speed" },
                new CheatCode { Code = "XP9QX9", Description = "Striker" },
                new CheatCode { Code = "R9CWTF", Description = "Swordsman" },
                new CheatCode { Code = "JWRGP4", Description = "Thunderstrike" },
                new CheatCode { Code = "D4RREH", Description = "Tigra" },
                new CheatCode { Code = "A7BRT4", Description = "Veil" },
            };
    }
}
