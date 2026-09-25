using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheVideoGame : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
