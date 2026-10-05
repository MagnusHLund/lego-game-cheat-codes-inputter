using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Views.Interfaces
{
    public interface IGameSelectionView
    {
        AbstractGame? Render(AbstractGame[] games);
    }
}
