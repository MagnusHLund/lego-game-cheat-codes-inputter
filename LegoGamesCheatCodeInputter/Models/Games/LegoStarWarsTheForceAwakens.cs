using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheForceAwakens : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Force Awakens";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
