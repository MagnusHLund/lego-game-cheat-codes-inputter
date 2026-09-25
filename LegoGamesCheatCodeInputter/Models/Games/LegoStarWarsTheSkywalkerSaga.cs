using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheSkywalkerSaga : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Skywalker Saga";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
