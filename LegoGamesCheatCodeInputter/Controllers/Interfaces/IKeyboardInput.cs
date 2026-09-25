namespace LegoGamesCheatCodeInputter.Controllers.Interfaces
{
    public enum InputKey
    {
        Up,
        Down,
        Right,
        Enter,
    }

    public interface IKeyboardInput : IDisposable
    {
        void Press(InputKey key);
    }
}
