using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Controllers;
using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Tests.Support.Fakes;

namespace LegoGamesCheatCodeInputter.Tests.Controllers;

public sealed class GameControllerTests
{
    [Fact]
    public async Task SuccessfulFlow_PassesSortedGamesAndSettings_ThenShowsCompletion()
    {
        FakeGame zebra = new("Zebra", [Code("B")]);
        FakeGame alpha = new("Alpha", [Code("A"), Code("C")]);
        RecordingSelectionView selection = new(alpha);
        RecordingStartingView starting = new();
        RecordingInputController input = new();
        RecordingCompletedView completed = new();
        RecordingErrorView errors = new();
        RecordingProgressView progress = new();
        GameController controller = CreateController(
            [zebra, alpha],
            selection,
            starting,
            input,
            completed,
            errors,
            progress
        );

        await controller.Main();

        Assert.Equal(new[] { "Alpha", "Zebra" }, selection.Games!.Select(game => game.Title));
        Assert.Same(alpha.Codes, input.Codes);
        Assert.Equal(("Alpha", 2, 0), starting.Arguments);
        Assert.Equal(1, completed.RenderCalls);
        Assert.Empty(errors.Exceptions);
        Assert.Equal(1, progress.RenderCalls);
    }

    [Fact]
    public async Task SelectionCancellation_SkipsCountdownAndInput()
    {
        RecordingSelectionView selection = new(null);
        RecordingStartingView starting = new();
        RecordingInputController input = new();
        RecordingCompletedView completed = new();
        RecordingErrorView errors = new();
        GameController controller = CreateController(
            [new FakeGame("One", [Code("A")])],
            selection,
            starting,
            input,
            completed,
            errors
        );

        await controller.Main();

        Assert.Null(starting.Arguments);
        Assert.Null(input.Codes);
        Assert.Equal(0, completed.RenderCalls);
        Assert.Empty(errors.Exceptions);
    }

    [Fact]
    public async Task InputFailure_ShowsErrorAndDoesNotShowCompletion()
    {
        InvalidOperationException failure = new("input failed");
        RecordingInputController input = new() { Failure = failure };
        RecordingCompletedView completed = new();
        RecordingErrorView errors = new();
        GameController controller = CreateController(
            [new FakeGame("One", [Code("A")])],
            new RecordingSelectionView(new FakeGame("One", [Code("A")])),
            new RecordingStartingView(),
            input,
            completed,
            errors
        );

        await controller.Main();

        Assert.Same(failure, Assert.Single(errors.Exceptions));
        Assert.Equal(0, completed.RenderCalls);
    }

    private static GameController CreateController(
        IReadOnlyList<AbstractGame> games,
        RecordingSelectionView selection,
        RecordingStartingView starting,
        RecordingInputController input,
        RecordingCompletedView completed,
        RecordingErrorView errors,
        RecordingProgressView? progress = null
    ) =>
        new(
            new AppSettings { FocusCountdownSeconds = 0 },
            games,
            input,
            selection,
            starting,
            completed,
            progress ?? new RecordingProgressView(),
            errors
        );

    private static CheatCode Code(string code) => new() { Code = code, Description = code };
}
