using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Controllers;
using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Tests.Support.Fakes;

namespace LegoGamesCheatCodeInputter.Tests.Controllers;

public sealed class InputControllerTests
{
    [Fact]
    public async Task InputsCharactersUsingShortestDirection_AndSubmitsCode()
    {
        RecordingKeyboard keyboard = new();
        List<TimeSpan> delays = new();
        InputController controller = CreateController(keyboard, delays);

        await controller.InputCheatCodes([Code("CZ")]);

        Assert.Equal(
            new[] { InputKey.Up, InputKey.Up, InputKey.Right }
                .Concat(Enumerable.Repeat(InputKey.Down, 11))
                .Concat([InputKey.Right, InputKey.Enter]),
            keyboard.Keys
        );
        Assert.All(delays, delay => Assert.Equal(TimeSpan.FromMilliseconds(0), delay));
    }

    [Fact]
    public async Task CharacterAtStartOfSequence_DoesNotMoveUpOrDown()
    {
        RecordingKeyboard keyboard = new();
        await CreateController(keyboard).InputCheatCodes([Code("A")]);

        Assert.Equal([InputKey.Right, InputKey.Enter], keyboard.Keys);
    }

    [Fact]
    public async Task DigitCharacters_AreAcceptedAndReachTheirExpectedPositions()
    {
        RecordingKeyboard keyboard = new();
        await CreateController(keyboard).InputCheatCodes([Code("Z9")]);

        Assert.Equal(
            Enumerable
                .Repeat(InputKey.Down, 11)
                .Append(InputKey.Right)
                .Append(InputKey.Down)
                .Append(InputKey.Right)
                .Append(InputKey.Enter),
            keyboard.Keys
        );
    }

    [Fact]
    public async Task MidpointTie_UsesUpDirection()
    {
        RecordingKeyboard keyboard = new();
        await CreateController(keyboard).InputCheatCodes([Code("S")]);

        Assert.Equal(18, keyboard.Keys.Count(key => key == InputKey.Up));
        Assert.DoesNotContain(InputKey.Down, keyboard.Keys);
    }

    [Fact]
    public async Task MultipleCodes_AreEnteredInListOrder_AndProgressReportsEachCompletion()
    {
        RecordingKeyboard keyboard = new();
        List<(int Completed, int Total, string Code)> progress = new();
        CheatCode first = Code("A");
        CheatCode second = Code("B");

        await CreateController(keyboard)
            .InputCheatCodes(
                [first, second],
                (completed, total, item) => progress.Add((completed, total, item.Code))
            );

        Assert.Equal(
            new[] { InputKey.Right, InputKey.Enter, InputKey.Up, InputKey.Right, InputKey.Enter },
            keyboard.Keys
        );
        Assert.Equal([(1, 2, "A"), (2, 2, "B")], progress);
    }

    [Fact]
    public async Task MultipleCodes_ContinuesFromPreviouslySelectedCharacters()
    {
        RecordingKeyboard keyboard = new();

        await CreateController(keyboard).InputCheatCodes([Code("Z"), Code("A")]);

        Assert.Equal(
            Enumerable
                .Repeat(InputKey.Down, 11)
                .Append(InputKey.Right)
                .Append(InputKey.Enter)
                .Concat(Enumerable.Repeat(InputKey.Up, 11))
                .Append(InputKey.Right)
                .Append(InputKey.Enter),
            keyboard.Keys
        );
    }

    [Fact]
    public async Task EmptyList_DoesNotCreateKeyboardOrSendKeys()
    {
        int factoryCalls = 0;
        InputController controller = new(
            keyboardInputFactory: () =>
            {
                factoryCalls++;
                return new RecordingKeyboard();
            },
            delay: _ => Task.CompletedTask
        );

        await controller.InputCheatCodes([]);

        Assert.Equal(0, factoryCalls);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("lower")]
    [InlineData("A B")]
    [InlineData("A-")]
    [InlineData("A_")]
    public async Task InvalidCode_ThrowsBeforeCreatingKeyboard(string code)
    {
        int factoryCalls = 0;
        InputController controller = new(keyboardInputFactory: () =>
        {
            factoryCalls++;
            return new RecordingKeyboard();
        });

        await Assert.ThrowsAsync<ArgumentException>(() => controller.InputCheatCodes([Code(code)]));
        Assert.Equal(0, factoryCalls);
    }

    [Fact]
    public async Task NullCodeEntry_ThrowsBeforeCreatingKeyboard()
    {
        int factoryCalls = 0;
        InputController controller = new(keyboardInputFactory: () =>
        {
            factoryCalls++;
            return new RecordingKeyboard();
        });

        await Assert.ThrowsAsync<ArgumentException>(() => controller.InputCheatCodes([null!]));
        Assert.Equal(0, factoryCalls);
    }

    [Fact]
    public async Task UsesConfiguredDelays()
    {
        RecordingKeyboard keyboard = new();
        List<TimeSpan> delays = new();
        InputController controller = new(
            new InputSettingsOptions
            {
                KeyHoldDurationMilliseconds = 44,
                KeyEventDelayMilliseconds = 11,
                CharacterSelectionDelayMilliseconds = 22,
                CodeSubmitDelayMilliseconds = 33,
            },
            () => keyboard,
            duration =>
            {
                delays.Add(duration);
                return Task.CompletedTask;
            }
        );

        await controller.InputCheatCodes([Code("B")]);

        Assert.Equal(
            new[]
            {
                TimeSpan.FromMilliseconds(44),
                TimeSpan.FromMilliseconds(11),
                TimeSpan.FromMilliseconds(22),
                TimeSpan.FromMilliseconds(44),
                TimeSpan.FromMilliseconds(11),
                TimeSpan.FromMilliseconds(44),
                TimeSpan.FromMilliseconds(11),
                TimeSpan.FromMilliseconds(33),
            },
            delays
        );
    }

    [Fact]
    public async Task KeyboardIsDisposedAfterSuccessAndFailure()
    {
        RecordingKeyboard successKeyboard = new();
        await CreateController(successKeyboard).InputCheatCodes([Code("A")]);
        Assert.True(successKeyboard.Disposed);

        RecordingKeyboard failureKeyboard = new() { FailOnPress = 1 };
        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            CreateController(failureKeyboard).InputCheatCodes([Code("A")])
        );
        Assert.True(failureKeyboard.Disposed);
    }

    [Fact]
    public async Task FailedCode_DoesNotReportProgress()
    {
        RecordingKeyboard keyboard = new() { FailOnPress = 1 };
        int progressCalls = 0;

        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            CreateController(keyboard).InputCheatCodes([Code("A")], (_, _, _) => progressCalls++)
        );

        Assert.Equal(0, progressCalls);
    }

    [Fact]
    public async Task FailureOnLaterCode_OnlyReportsEarlierCompletedCodes()
    {
        RecordingKeyboard keyboard = new() { FailOnPress = 5 };
        List<int> completedCodes = new();

        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            CreateController(keyboard)
                .InputCheatCodes(
                    [Code("A"), Code("C")],
                    (completed, _, _) => completedCodes.Add(completed)
                )
        );

        Assert.Equal([1], completedCodes);
        Assert.True(keyboard.Disposed);
    }

    private static InputController CreateController(
        RecordingKeyboard keyboard,
        List<TimeSpan>? delays = null
    ) =>
        new(
            new InputSettingsOptions
            {
                KeyHoldDurationMilliseconds = 0,
                KeyEventDelayMilliseconds = 0,
                CharacterSelectionDelayMilliseconds = 0,
                CodeSubmitDelayMilliseconds = 0,
            },
            () => keyboard,
            delay: duration =>
            {
                delays?.Add(duration);
                return Task.CompletedTask;
            }
        );

    private static CheatCode Code(string value) => new() { Code = value, Description = value };
}
