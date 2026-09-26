using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Controllers
{
    public sealed class InputController : IInputController
    {
        private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private readonly Func<IKeyboardInput> _keyboardInputFactory;
        private readonly InputSettingsOptions _inputSettings;
        private readonly Func<TimeSpan, Task> _delay;

        public InputController()
            : this(new InputSettingsOptions()) { }

        public InputController(
            InputSettingsOptions? inputSettings = null,
            Func<IKeyboardInput>? keyboardInputFactory = null,
            Func<TimeSpan, Task>? delay = null
        )
        {
            _keyboardInputFactory = keyboardInputFactory ?? (() => new SharpHookKeyboardInput());
            _inputSettings = inputSettings ?? new InputSettingsOptions();
            _delay = delay ?? Task.Delay;
        }

        public async Task InputCheatCodes(
            IReadOnlyList<CheatCode> cheatCodes,
            Action<int, int, CheatCode>? onCodeCompleted = null
        )
        {
            ArgumentNullException.ThrowIfNull(cheatCodes);
            ValidateCodes(cheatCodes);
            if (cheatCodes.Count == 0)
                return;

            using IKeyboardInput keyboard = _keyboardInputFactory();
            for (int codeIndex = 0; codeIndex < cheatCodes.Count; codeIndex++)
            {
                CheatCode cheatCode = cheatCodes[codeIndex];

                // Assumes each code-entry position starts at A, Right advances to the next position,
                // and Enter submits the completed code. Focus the game's code-entry screen first.
                foreach (char character in cheatCode.Code)
                {
                    int targetIndex = Characters.IndexOf(character);
                    int upDistance = targetIndex;
                    int downDistance = Characters.Length - targetIndex;
                    InputKey direction = upDistance <= downDistance ? InputKey.Up : InputKey.Down;

                    for (int step = 0; step < Math.Min(upDistance, downDistance); step++)
                    {
                        await PressKey(keyboard, direction);
                    }

                    await Delay(_inputSettings.CharacterSelectionDelayMilliseconds);
                    await PressKey(keyboard, InputKey.Right);
                }

                await PressKey(keyboard, InputKey.Enter);
                await Delay(_inputSettings.CodeSubmitDelayMilliseconds);
                onCodeCompleted?.Invoke(codeIndex + 1, cheatCodes.Count, cheatCode);
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

        private Task Delay(int milliseconds) => _delay(TimeSpan.FromMilliseconds(milliseconds));
    }
}
