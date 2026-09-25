using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Tests.Support.Collections;
using LegoGamesCheatCodeInputter.Tests.Support.Fakes;
using LegoGamesCheatCodeInputter.Views;
using LegoGamesCheatCodeInputter.Views.Menus;

namespace LegoGamesCheatCodeInputter.Tests.Views;

[Collection(ConsoleCollection.Name)]
public sealed class ConsoleViewTests
{
    [Fact]
    public void GameMenu_ReturnsSelectedGameAfterArrowNavigation()
    {
        IGame first = new FakeGame("First", []);
        IGame second = new FakeGame("Second", []);
        Queue<ConsoleKeyInfo> keys = new([Key(ConsoleKey.DownArrow), Key(ConsoleKey.Enter)]);
        using StringWriter output = new();
        TextWriter original = Console.Out;
        Console.SetOut(output);
        try
        {
            SelectGameMenuView view = new(() => keys.Dequeue());

            Assert.Same(second, view.Render([first, second]));
        }
        finally
        {
            Console.SetOut(original);
        }
    }

    [Fact]
    public void GameMenu_EscapeCancels()
    {
        using StringWriter output = new();
        TextWriter original = Console.Out;
        Console.SetOut(output);
        try
        {
            SelectGameMenuView view = new(() => Key(ConsoleKey.Escape));
            Assert.Null(view.Render([new FakeGame("Game", [])]));
        }
        finally
        {
            Console.SetOut(original);
        }
    }

    [Fact]
    public void GameMenu_RejectsEmptyGameList()
    {
        SelectGameMenuView view = new(() =>
            throw new Xunit.Sdk.XunitException("Should not request input.")
        );

        Assert.Throws<InvalidOperationException>(() => view.Render([]));
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 4)]
    public async Task StartingView_UsesExpectedCountdownDelays(int seconds, int expectedDelays)
    {
        List<TimeSpan> delays = new();
        using StringWriter output = new();
        TextWriter original = Console.Out;
        Console.SetOut(output);
        try
        {
            StartingWorkView view = new(
                readLine: () => string.Empty,
                delay: duration =>
                {
                    delays.Add(duration);
                    return Task.CompletedTask;
                }
            );

            await view.Render("Test game", 3, seconds);
        }
        finally
        {
            Console.SetOut(original);
        }

        Assert.Equal(expectedDelays, delays.Count);
        Assert.All(delays, delay => Assert.Equal(TimeSpan.FromSeconds(1), delay));
    }

    private static ConsoleKeyInfo Key(ConsoleKey key) => new('\0', key, false, false, false);
}
