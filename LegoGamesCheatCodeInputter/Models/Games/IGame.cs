namespace LegoGamesCheatCodeInputter.Models.Games
{
    public interface IGame
    {
        string Title { get; }
        IReadOnlyList<CheatCode> Codes { get; }
    }
}
