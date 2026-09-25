using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Views
{
    public sealed class StartingWorkView : IStartingWorkView
    {
        private readonly Func<string?> _readLine;
        private readonly Func<TimeSpan, Task> _delay;

        public StartingWorkView(Func<string?>? readLine = null, Func<TimeSpan, Task>? delay = null)
        {
            _readLine = readLine ?? Console.ReadLine;
            _delay = delay ?? Task.Delay;
        }

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

            Console.WriteLine($"Press enter to start the {countdownSeconds} second countdown");
            _readLine();
            Console.WriteLine("  Starting in:");

            for (int seconds = countdownSeconds; seconds > 0; seconds--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  {seconds}");
                Console.ResetColor();
                await _delay(TimeSpan.FromSeconds(1));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!  ");
            Console.ResetColor();
        }
    }
}
