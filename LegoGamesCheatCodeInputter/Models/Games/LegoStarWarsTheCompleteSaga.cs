using System.Collections.Generic;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheCompleteSaga : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Complete Saga";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode> { };
    }
}
