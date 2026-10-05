using LegoGamesCheatCodeInputter.Controllers.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games.Interfaces
{
    public abstract class AbstractGame
    {
        public abstract string Title { get; }
        public virtual InputKey[] DefaultSubmitInputs { get; } = { InputKey.Enter };
        public virtual InputOptimizations InputOptimizations { get; } =
            new InputOptimizations { CanResetByGoingRight = true };
        public abstract IReadOnlyList<CheatCode> Codes { get; }
    }
}
