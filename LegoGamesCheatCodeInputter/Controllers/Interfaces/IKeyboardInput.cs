namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public enum InputKey
    {
        Up,
        Down,
        Right,
        Left,
        Enter,
    }

    public interface IKeyboardInput : IDisposable
    {
        void Press(InputKey key);
        void Release(InputKey key);
    }
}
