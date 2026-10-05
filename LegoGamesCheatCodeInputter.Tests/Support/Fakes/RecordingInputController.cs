using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingInputController : IInputController
{
    public IReadOnlyList<CheatCode>? Codes { get; private set; }
    public Exception? Failure { get; init; }

    public Task InputCheatCodes(
        AbstractGame game,
        Action<int, int, CheatCode>? onCodeCompleted = null
    )
    {
        Codes = game.Codes;
        if (Failure is not null)
            throw Failure;
        if (Codes is not null && Codes.Count > 0)
            onCodeCompleted?.Invoke(1, Codes.Count, Codes[0]);
        return Task.CompletedTask;
    }
}
