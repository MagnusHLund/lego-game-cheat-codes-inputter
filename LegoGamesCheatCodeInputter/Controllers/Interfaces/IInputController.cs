using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public interface IInputController
    {
        Task InputCheatCodes(
            IReadOnlyList<CheatCode> cheatCodes,
            Action<int, int, CheatCode>? onCodeCompleted = null
        );
    }
}
