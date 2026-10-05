using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingSelectionView(AbstractGame? result) : IGameSelectionView
{
    public AbstractGame[]? Games { get; private set; }

    public AbstractGame? Render(AbstractGame[] games)
    {
        Games = games;
        return result;
    }
}
