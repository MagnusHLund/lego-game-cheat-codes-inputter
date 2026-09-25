using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoWorlds : IGame
    {
        public string Title { get; } = "Lego Worlds";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
