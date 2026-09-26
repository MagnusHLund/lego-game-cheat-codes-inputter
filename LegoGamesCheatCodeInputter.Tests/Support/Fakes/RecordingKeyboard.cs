using LegoGamesCheatCodeInputter.Controllers.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingKeyboard : IKeyboardInput
{
    public List<InputKey> Keys { get; } = new();
    public bool Disposed { get; private set; }
    public int? FailOnPress { get; init; }

    public void Press(InputKey key)
    {
        if (FailOnPress == Keys.Count + 1)
            throw new InvalidOperationException("Synthetic keyboard failure.");
        Keys.Add(key);
    }

    public void Release(InputKey key) { }

    public void Dispose() => Disposed = true;
}
