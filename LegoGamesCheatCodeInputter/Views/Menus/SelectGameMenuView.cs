using LegoGamesCheatCodeInputter.Models.Games;

namespace LegoGamesCheatCodeInputter.Views.Menus
{
    public sealed class SelectGameMenuView : AbstractMenu
    {
        public IGame? Render(IGame[] games)
        {
            ArgumentNullException.ThrowIfNull(games);
            if (games.Length == 0)
                throw new InvalidOperationException("No games are registered.");

            int selectedIndex = 0;

            string[] gameTitles = games.Select(game => game.Title).ToArray();

            while (true)
            {
                RenderMenu(gameTitles, selectedIndex);

                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex--;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex++;
                        break;

                    case ConsoleKey.Enter:
                        return games[selectedIndex];

                    case ConsoleKey.Escape:
                        return null;
                }

                selectedIndex = Math.Clamp(selectedIndex, 0, games.Length - 1);
            }
        }
    }
}
