using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class TheLegoMovieVideoGame : IGame
    {
        public string Title { get; } = "The Lego Movie Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
