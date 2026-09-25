namespace LegoGamesCheatCodeInputter.Views
{
    public sealed class StartingWorkView
    {
        public async Task Render(string gameTitle, int codeCount, int countdownSeconds)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  LEGO  /  CHEAT CODE INPUTTER");
            Console.ResetColor();
            Console.WriteLine(
                "  ─────────────────────────────────────────────────────────────────"
            );
            Console.WriteLine();
            Console.Write("  GAME      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(gameTitle);
            Console.ResetColor();
            Console.WriteLine($"  CODES     {codeCount} cheat codes");
            Console.WriteLine();
            Console.WriteLine("  Before we begin:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  • Open the game's Enter Code screen.");
            Console.WriteLine("  • Make sure the game window is focused.");
            Console.WriteLine("  • Keep your hands off the keyboard while codes are entered.");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Press enter to start the 5 second countdown");
            Console.ReadLine();
            Console.WriteLine("  Starting in:");

            for (int seconds = countdownSeconds; seconds > 0; seconds--)
            {
                Console.SetCursorPosition(2, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{seconds}   ");
                Console.ResetColor();
                await Task.Delay(1000);
            }

            Console.SetCursorPosition(2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!  ");
            Console.ResetColor();
        }
    }
}
