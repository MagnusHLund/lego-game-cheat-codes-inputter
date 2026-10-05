using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Views.Menus
{
    public sealed class SelectGameMenuView : AbstractMenu, IGameSelectionView
    {
        private readonly Func<ConsoleKeyInfo> _readKey;

        public SelectGameMenuView(Func<ConsoleKeyInfo>? readKey = null)
        {
            _readKey = readKey ?? (() => Console.ReadKey(true));
        }

        public AbstractGame? Render(AbstractGame[] games)
        {
            ArgumentNullException.ThrowIfNull(games);
            if (games.Length == 0)
                throw new InvalidOperationException("No games are registered.");

            int selectedIndex = 0;

            string[] gameTitles = games.Select(game => game.Title).ToArray();

            while (true)
            {
                RenderMenu(gameTitles, selectedIndex);

                var key = _readKey();

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
