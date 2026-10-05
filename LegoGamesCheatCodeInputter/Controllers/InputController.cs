using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Controllers
{
    public sealed class InputController : IInputController
    {
        private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private readonly ICheatCodeOptimizationController _cheatCodeOptimizationController;

        private readonly Func<IKeyboardInput> _keyboardInputFactory;
        private readonly InputSettingsOptions _inputSettings;
        private readonly Func<TimeSpan, Task> _delay;

        public InputController()
            : this(new InputSettingsOptions()) { }

        public InputController(
            InputSettingsOptions? inputSettings = null,
            Func<IKeyboardInput>? keyboardInputFactory = null,
            Func<TimeSpan, Task>? delay = null,
            ICheatCodeOptimizationController? cheatCodeOptimizationController = null
        )
        {
            _keyboardInputFactory = keyboardInputFactory ?? (() => new SharpHookKeyboardInput());
            _inputSettings = inputSettings ?? new InputSettingsOptions();
            _delay = delay ?? Task.Delay;

            _cheatCodeOptimizationController =
                cheatCodeOptimizationController ?? new CheatCodeOptimizationController();
        }

        public async Task InputCheatCodes(
            AbstractGame game,
            Action<int, int, CheatCode>? onCodeCompleted = null
        )
        {
            ArgumentNullException.ThrowIfNull(game);
            ValidateCodes(game.Codes);
            if (game.Codes.Count == 0)
            {
                return;
            }

            IReadOnlyList<CheatCode> optimizedCheatCodes =
                _cheatCodeOptimizationController.Optimize(game.Codes);

            int[] currentCharacterIndices = new int[game.Codes.Max(item => item.Code.Length)];

            using IKeyboardInput keyboard = _keyboardInputFactory();
            for (int codeIndex = 0; codeIndex < game.Codes.Count; codeIndex++)
            {
                CheatCode cheatCode = optimizedCheatCodes[codeIndex];

                // The screen starts at AAAAAA, but keeps the entered characters after submitting.
                // Track each position so later codes move from the game's current selection.
                for (int position = 0; position < cheatCode.Code.Length; position++)
                {
                    char character = cheatCode.Code[position];
                    int targetIndex = Characters.IndexOf(character);
                    int currentIndex = currentCharacterIndices[position];
                    int upDistance =
                        (targetIndex - currentIndex + Characters.Length) % Characters.Length;
                    int downDistance =
                        (currentIndex - targetIndex + Characters.Length) % Characters.Length;
                    InputKey direction = upDistance <= downDistance ? InputKey.Up : InputKey.Down;

                    for (int step = 0; step < Math.Min(upDistance, downDistance); step++)
                    {
                        await PressKey(keyboard, direction);
                    }

                    currentCharacterIndices[position] = targetIndex;
                    await Delay(_inputSettings.CharacterSelectionDelayMilliseconds);
                    await PressKey(keyboard, InputKey.Right);
                }

                await SubmitCode(keyboard, game.DefaultSubmitInputs);
                await Delay(_inputSettings.CodeSubmitDelayMilliseconds);

                if (!game.InputOptimizations.CanResetByGoingRight)
                {
                    // Move back to the first character position for the next code.
                    for (int step = 0; step < cheatCode.Code.Length; step++)
                    {
                        await PressKey(keyboard, InputKey.Left);
                    }
                }

                CheatCode? nextCheatCode =
                    codeIndex + 1 < optimizedCheatCodes.Count
                        ? optimizedCheatCodes[codeIndex + 1]
                        : null;

                onCodeCompleted?.Invoke(
                    codeIndex + 1,
                    game.Codes.Count,
                    nextCheatCode ?? cheatCode
                );
            }
        }

        private static void ValidateCodes(IReadOnlyList<CheatCode> cheatCodes)
        {
            for (int i = 0; i < cheatCodes.Count; i++)
            {
                CheatCode item =
                    cheatCodes[i]
                    ?? throw new ArgumentException(
                        $"Code at index {i} is null.",
                        nameof(cheatCodes)
                    );
                if (string.IsNullOrWhiteSpace(item.Code))
                    throw new ArgumentException($"Code at index {i} is blank.", nameof(cheatCodes));

                foreach (char character in item.Code)
                {
                    if (Characters.IndexOf(character) < 0)
                        throw new ArgumentException(
                            $"Code '{item.Code}' contains unsupported character '{character}'. Codes must use A-Z and 0-9 uppercase.",
                            nameof(cheatCodes)
                        );
                }
            }
        }

        private async Task PressKey(IKeyboardInput keyboard, InputKey key)
        {
            keyboard.Press(key);
            try
            {
                await Delay(_inputSettings.KeyHoldDurationMilliseconds);
            }
            finally
            {
                keyboard.Release(key);
            }

            await Delay(_inputSettings.KeyEventDelayMilliseconds);
        }

        private async Task SubmitCode(IKeyboardInput keyboard, InputKey[] submitInputs)
        {
            foreach (InputKey key in submitInputs)
            {
                await PressKey(keyboard, key);
            }
        }

        private Task Delay(int milliseconds) => _delay(TimeSpan.FromMilliseconds(milliseconds));

        public async Task InputCheatCodes()
        {
            throw new NotImplementedException();
        }
    }
}
