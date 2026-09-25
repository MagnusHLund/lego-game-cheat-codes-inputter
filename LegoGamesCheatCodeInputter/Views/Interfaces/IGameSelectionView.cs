using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Views.Interfaces
{
    public interface IGameSelectionView
    {
        IGame? Render(IGame[] games);
    }
}
