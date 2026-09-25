namespace LegoGamesCheatCodeInputter.Views
{
    public class StartingWorkView
    {
        public async Task Render(string gameTitle)
        {
            Console.Clear();

            Console.WriteLine($"Enter {gameTitle} now!");

            decimal countdown = 5;

            while (countdown > 0)
            {
                await Task.Delay(100);
                countdown -= 0.1m;
                Console.WriteLine($"Countdown: {countdown:F1}");
            }

            Console.WriteLine("STARTED!");
        }
    }
}
