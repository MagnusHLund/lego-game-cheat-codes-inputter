using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games;
using LegoGamesCheatCodeInputter.Views;
using LegoGamesCheatCodeInputter.Views.Menus;

namespace LegoGamesCheatCodeInputter.Controllers
{
    public sealed class GameController
    {
        private readonly InputController _inputController;

        private readonly CompletedView _completedView;
        private readonly StartingWorkView _startingWorkView;
        private readonly SelectGameMenuView _selectGameMenuView;

        public GameController()
        {
            // Controllers
            _inputController = new InputController();

            // Views
            _completedView = new CompletedView();
            _startingWorkView = new StartingWorkView();
            _selectGameMenuView = new SelectGameMenuView();
        }

        public async Task Main()
        {
            IGame[] games = GetGames();
            IGame selectedGame = _selectGameMenuView.Render(games);

            await _startingWorkView.Render(selectedGame.Title);

            _inputController.InputCheatCodes(selectedGame.Codes);
            _completedView.Render();
        }

        private IGame[] GetGames()
        {
            return GameRegistry.Games.OrderBy(g => g.Title).ToArray();
        }
    }
}
