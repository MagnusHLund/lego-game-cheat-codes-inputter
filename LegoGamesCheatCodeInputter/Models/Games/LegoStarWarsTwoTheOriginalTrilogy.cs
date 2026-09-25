using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTwoTheOriginalTrilogy : IGame
    {
        public string Title { get; } = "Lego Star Wars II: The Original Trilogy";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
