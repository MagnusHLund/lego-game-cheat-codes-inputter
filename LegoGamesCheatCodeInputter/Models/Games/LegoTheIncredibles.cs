using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoTheIncredibles : IGame
    {
        public string Title { get; } = "Lego The Incredibles";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
