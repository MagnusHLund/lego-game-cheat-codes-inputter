namespace LegoGamesCheatCodeInputter.Views.Interfaces
{
    public interface IStartingWorkView
    {
        Task Render(string gameTitle, int codeCount, int countdownSeconds);
    }
}
