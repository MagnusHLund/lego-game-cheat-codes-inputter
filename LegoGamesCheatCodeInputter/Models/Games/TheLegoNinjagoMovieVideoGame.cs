using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class TheLegoNinjagoMovieVideoGame : IGame
    {
        public string Title { get; } = "The Lego Ninjago Movie Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
