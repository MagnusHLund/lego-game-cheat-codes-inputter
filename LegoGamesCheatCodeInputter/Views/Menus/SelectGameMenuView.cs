using LegoGamesCheatCodeInputter.Models.Games;

namespace LegoGamesCheatCodeInputter.Views.Menus
{
    public sealed class SelectGameMenuView : AbstractMenu
    {
        public IGame Render(IGame[] games)
        {
            int selectedIndex = 0;

            string[] GameTitles = games.Select(game => game.Title).ToArray();

            while (true)
            {
                Console.Clear();

                RenderMenu(GameTitles, selectedIndex);

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
                }

                selectedIndex = Math.Clamp(selectedIndex, 0, games.Length - 1);
            }
        }
    }
}
