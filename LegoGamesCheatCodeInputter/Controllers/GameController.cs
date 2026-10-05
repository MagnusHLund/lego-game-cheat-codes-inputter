using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;
using LegoGamesCheatCodeInputter.Views;
using LegoGamesCheatCodeInputter.Views.Interfaces;
using LegoGamesCheatCodeInputter.Views.Menus;

namespace LegoGamesCheatCodeInputter.Controllers
{
    public sealed class GameController
    {
        private readonly IInputController _inputController;

        private readonly ICompletedView _completedView;
        private readonly IStartingWorkView _startingWorkView;
        private readonly IGameSelectionView _selectGameMenuView;
        private readonly IProgressView _progressView;
        private readonly IErrorView _errorView;

        private readonly AppSettings _settings;
        private readonly IReadOnlyList<AbstractGame> _games;

        public GameController(
            AppSettings settings,
            IReadOnlyList<AbstractGame>? games = null,
            IInputController? inputController = null,
            IGameSelectionView? gameSelectionView = null,
            IStartingWorkView? startingWorkView = null,
            ICompletedView? completedView = null,
            IProgressView? progressView = null,
            IErrorView? errorView = null
        )
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            _games = games ?? GameRegistry.Games;
            // Controllers
            _inputController = inputController ?? new InputController(settings.Input);

            // Views
            _completedView = completedView ?? new CompletedView();
            _startingWorkView = startingWorkView ?? new StartingWorkView();
            _selectGameMenuView = gameSelectionView ?? new SelectGameMenuView();
            _progressView = progressView ?? new ProgressView();
            _errorView = errorView ?? new ErrorView();
        }

        public async Task Main()
        {
            AbstractGame[] games = GetGames();
            AbstractGame? selectedGame = _selectGameMenuView.Render(games);
            if (selectedGame is null)
                return;

            await _startingWorkView.Render(
                selectedGame.Title,
                selectedGame.Codes.Count,
                _settings.FocusCountdownSeconds
            );

            try
            {
                await _inputController.InputCheatCodes(selectedGame, _progressView.Render);
                _completedView.Render();
            }
            catch (Exception exception)
            {
                _errorView.Render(exception);
            }
        }

        private AbstractGame[] GetGames()
        {
            return _games.OrderBy(g => g.Title).ToArray();
        }
    }
}
