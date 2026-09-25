using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingStartingView : IStartingWorkView
{
    public (string Title, int CodeCount, int Countdown)? Arguments { get; private set; }

    public Task Render(string gameTitle, int codeCount, int countdownSeconds)
    {
        Arguments = (gameTitle, codeCount, countdownSeconds);
        return Task.CompletedTask;
    }
}
