using LegoGamesCheatCodeInputter.Controllers;
using LegoGamesCheatCodeInputter.Configuration;

namespace LegoGamesCheatCodeInputter
{
    sealed class Program
    {
        static async Task Main()
        {
            AppSettings settings = AppSettings.Load();
            await new GameController(settings).Main();
        }
    }
}
