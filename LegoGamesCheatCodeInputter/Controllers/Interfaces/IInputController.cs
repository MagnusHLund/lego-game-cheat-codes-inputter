using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public interface IInputController
    {
        Task InputCheatCodes(
            AbstractGame game,
            Action<int, int, CheatCode>? onCodeCompleted = null
        );
    }
}
