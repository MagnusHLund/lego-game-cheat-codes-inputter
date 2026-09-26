using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoTheIncredibles : IGame
    {
        public string Title { get; } = "Lego The Incredibles";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "BRAB1R", Description = "Edna Mode" },
                new CheatCode { Code = "G1MHR7", Description = "Gamma Jack" },
            };
    }
}
