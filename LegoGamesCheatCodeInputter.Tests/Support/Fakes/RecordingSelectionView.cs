using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingSelectionView(IGame? result) : IGameSelectionView
{
    public IGame[]? Games { get; private set; }

    public IGame? Render(IGame[] games)
    {
        Games = games;
        return result;
    }
}
