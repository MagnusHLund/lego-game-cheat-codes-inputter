using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class TheLegoMovieTwoVideoGame : IGame
    {
        public string Title { get; } = "The Lego Movie Two Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
