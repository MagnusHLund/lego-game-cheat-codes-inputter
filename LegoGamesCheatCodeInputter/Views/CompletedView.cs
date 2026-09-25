using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Views
{
    public sealed class CompletedView : ICompletedView
    {
        public void Render()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  LEGO  /  CHEAT CODE INPUTTER");
            Console.ResetColor();
            Console.WriteLine("  ─────────────────────────────────────────────────────────────────");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ✓  All cheat codes have been entered.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  Check the game to confirm it accepted them.");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
