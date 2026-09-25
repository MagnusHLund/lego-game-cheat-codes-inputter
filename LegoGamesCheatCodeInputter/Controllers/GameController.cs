using LegoGamesCheatCodeInputter.Configuration;
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
        private readonly ProgressView _progressView;
        private readonly ErrorView _errorView;

        private readonly AppSettings _settings;

        public GameController(AppSettings settings)
        {
            _settings = settings;
            // Controllers
            _inputController = new InputController();

            // Views
            _completedView = new CompletedView();
            _startingWorkView = new StartingWorkView();
            _selectGameMenuView = new SelectGameMenuView();
            _progressView = new ProgressView();
            _errorView = new ErrorView();
        }

        public async Task Main()
        {
            IGame[] games = GetGames();
            IGame? selectedGame = _selectGameMenuView.Render(games);
            if (selectedGame is null)
                return;

            await _startingWorkView.Render(
                selectedGame.Title,
                selectedGame.Codes.Count,
                _settings.FocusCountdownSeconds
            );

            try
            {
                await _inputController.InputCheatCodes(selectedGame.Codes, _progressView.Render);
                _completedView.Render();
            }
            catch (Exception exception)
            {
                _errorView.Render(exception);
            }
        }

        private IGame[] GetGames()
        {
            return GameRegistry.Games.OrderBy(g => g.Title).ToArray();
        }
    }
}
