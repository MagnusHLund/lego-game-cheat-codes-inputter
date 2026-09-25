using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoTheHobbit : IGame
    {
        public string Title { get; } = "Lego The Hobbit";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
