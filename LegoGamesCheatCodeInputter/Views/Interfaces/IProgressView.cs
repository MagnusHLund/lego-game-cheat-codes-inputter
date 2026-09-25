using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Views.Interfaces
{
    public interface IProgressView
    {
        void Render(int completedCount, int totalCount, CheatCode completedCode);
    }
}
