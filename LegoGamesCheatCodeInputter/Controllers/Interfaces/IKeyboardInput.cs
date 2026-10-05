namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public enum InputKey
    {
        Up,
        Down,
        Right,
        Left,
        Enter,
        U,
        NumPad5,
    }

    public interface IKeyboardInput : IDisposable
    {
        void Press(InputKey key);
        void Release(InputKey key);
    }
}
