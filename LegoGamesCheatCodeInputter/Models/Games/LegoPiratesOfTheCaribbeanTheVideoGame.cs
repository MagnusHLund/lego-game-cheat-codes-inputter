using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoPiratesOfTheCaribbeanTheVideoGame : IGame
    {
        public string Title { get; } = "Lego Pirates of the Caribbean: The Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
