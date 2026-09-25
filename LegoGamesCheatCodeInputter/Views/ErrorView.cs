namespace LegoGamesCheatCodeInputter.Views
{
    public sealed class ErrorView
    {
        public void Render(Exception exception)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  LEGO  /  CHEAT CODE INPUTTER");
            Console.ResetColor();
            Console.WriteLine("  ─────────────────────────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("  Input could not be completed.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"  {exception.Message}");
            Console.ResetColor();
        }
    }
}
