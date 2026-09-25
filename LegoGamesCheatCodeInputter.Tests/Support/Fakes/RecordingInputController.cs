using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingInputController : IInputController
{
    public IReadOnlyList<CheatCode>? Codes { get; private set; }
    public Exception? Failure { get; init; }

    public Task InputCheatCodes(
        IReadOnlyList<CheatCode> cheatCodes,
        Action<int, int, CheatCode>? onCodeCompleted = null
    )
    {
        Codes = cheatCodes;
        if (Failure is not null)
            throw Failure;
        if (cheatCodes.Count > 0)
            onCodeCompleted?.Invoke(1, cheatCodes.Count, cheatCodes[0]);
        return Task.CompletedTask;
    }
}
