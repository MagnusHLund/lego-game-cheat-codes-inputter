using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Views
{
    public sealed class ProgressView
    {
        public void Render(int completedCount, int totalCount, CheatCode completedCode)
        {
            int percent = (int)Math.Round(completedCount * 100d / totalCount);
            const int barWidth = 24;
            int filled = (int)Math.Round(barWidth * completedCount / (double)totalCount);

            Console.Write("\r  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(new string('█', filled));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(new string('─', barWidth - filled));
            Console.ResetColor();
            Console.Write($"  {completedCount,2}/{totalCount,-2}  {percent,3}%   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(completedCode.Description);
            Console.ResetColor();
            Console.Write(new string(' ', 16));

            if (completedCount == totalCount)
                Console.WriteLine();
        }
    }
}
