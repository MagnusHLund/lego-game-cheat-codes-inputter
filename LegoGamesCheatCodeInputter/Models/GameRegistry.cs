using LegoGamesCheatCodeInputter.Models.Games;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models
{
    public static class GameRegistry
    {
        public static IReadOnlyList<IGame> Games { get; } =
            new List<IGame> { new LegoHarryPotterYears1To4(), new LegoHarryPotterYears5To7() };
    }
}
