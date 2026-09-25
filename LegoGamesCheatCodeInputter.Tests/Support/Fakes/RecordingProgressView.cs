using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingProgressView : IProgressView
{
    public int RenderCalls { get; private set; }

    public void Render(int completedCount, int totalCount, CheatCode completedCode) =>
        RenderCalls++;
}
