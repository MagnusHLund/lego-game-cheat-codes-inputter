using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingCompletedView : ICompletedView
{
    public int RenderCalls { get; private set; }

    public void Render() => RenderCalls++;
}
