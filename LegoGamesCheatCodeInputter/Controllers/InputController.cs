using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Controllers
{
    public sealed class InputController
    {
        private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const int KeyDelayMilliseconds = 60;
        private const int CharacterDelayMilliseconds = 120;

        private readonly Func<IKeyboardInput> _keyboardInputFactory;

        public InputController()
            : this(() => new SharpHookKeyboardInput()) { }

        public InputController(Func<IKeyboardInput> keyboardInputFactory)
        {
            _keyboardInputFactory = keyboardInputFactory
                ?? throw new ArgumentNullException(nameof(keyboardInputFactory));
        }

        public void InputCheatCodes(IReadOnlyList<CheatCode> cheatCodes)
        {
            ArgumentNullException.ThrowIfNull(cheatCodes);
            ValidateCodes(cheatCodes);

            using IKeyboardInput keyboard = _keyboardInputFactory();
            foreach (CheatCode cheatCode in cheatCodes)
            {
                // Assumes each code-entry position starts at A, Right advances to the next position,
                // and Enter submits the completed code. Focus the game's code-entry screen first.
                foreach (char character in cheatCode.Code)
                {
                    int targetIndex = Characters.IndexOf(character);
                    int upDistance = targetIndex;
                    int downDistance = Characters.Length - targetIndex;
                    InputKey direction = upDistance <= downDistance ? InputKey.Up : InputKey.Down;

                    for (int step = 0; step < Math.Min(upDistance, downDistance); step++)
                        PressKey(keyboard, direction);

                    Thread.Sleep(CharacterDelayMilliseconds);
                    PressKey(keyboard, InputKey.Right);
                }

                PressKey(keyboard, InputKey.Enter);
                Thread.Sleep(CharacterDelayMilliseconds);
            }
        }

        private static void ValidateCodes(IReadOnlyList<CheatCode> cheatCodes)
        {
            for (int i = 0; i < cheatCodes.Count; i++)
            {
                CheatCode item = cheatCodes[i]
                    ?? throw new ArgumentException($"Code at index {i} is null.", nameof(cheatCodes));
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

        private static void PressKey(IKeyboardInput keyboard, InputKey key)
        {
            keyboard.Press(key);
            Thread.Sleep(KeyDelayMilliseconds);
        }
    }
}
