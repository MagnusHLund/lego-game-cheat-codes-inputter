using LegoGamesCheatCodeInputter.Controllers;

namespace LegoGamesCheatCodeInputter
{
    sealed class Program
    {
        static async Task Main()
        {
            await new GameController().Main();
        }
    }
}
