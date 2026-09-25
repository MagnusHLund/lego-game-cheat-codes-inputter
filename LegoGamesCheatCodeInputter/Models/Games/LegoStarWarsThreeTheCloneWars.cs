using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsThreeTheCloneWars : IGame
    {
        public string Title { get; } = "Lego Star Wars III: The Clone Wars";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
