using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class FakeGame : AbstractGame
{
    public override string Title { get; }
    public override IReadOnlyList<CheatCode> Codes { get; }

    public FakeGame(string title, IReadOnlyList<CheatCode> codes)
    {
        Title = title;
        Codes = codes;
    }
}
