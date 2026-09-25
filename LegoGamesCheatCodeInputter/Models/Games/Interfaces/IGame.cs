namespace LegoGamesCheatCodeInputter.Models.Games.Interfaces
{
    public interface IGame
    {
        string Title { get; }
        IReadOnlyList<CheatCode> Codes { get; }
    }
}
