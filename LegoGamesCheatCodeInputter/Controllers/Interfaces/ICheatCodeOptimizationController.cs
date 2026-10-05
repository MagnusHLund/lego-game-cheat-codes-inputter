using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public interface ICheatCodeOptimizationController
    {
        IReadOnlyList<CheatCode> Optimize(IReadOnlyList<CheatCode> cheatCodes);
    }
}
