using LegoGamesCheatCodeInputter.Models.Games;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models
{
    public static class GameRegistry
    {
        public static IReadOnlyList<AbstractGame> Games { get; } =
            new List<AbstractGame>
            {
                new LegoBatmanTheVideoGame(),
                new LegoBatmanTwoDcSuperHeroes(),
                new LegoBatmanThreeBeyondGotham(),
                // new LegoCityUndercover(), //! Make it so the inputter automatically makes the last input field be blank.
                // new LegoDcSuperVillains(), //! The input system seems to have other delays, which are incompatible with how the rest of the support games work.
                new LegoHarryPotterYearsOneToFour(),
                new LegoHarryPotterYearsFiveToSeven(),
                // new LegoIndianaJonesTheOriginalAdventures(), //! The input system seems to have other delays, which are incompatible with how the rest of the support games work.
                new LegoIndianaJonesTwoTheAdventureContinues(),
                new LegoJurassicWorld(),
                new LegoLordOfTheRings(),
                new LegoMarvelAvengers(),
                new LegoMarvelSuperHeroes(),
                // new LegoMarvelSuperHeroesTwo(), //! keyboard input system, rather than up and down arrows.
                new LegoPiratesOfTheCaribbeanTheVideoGame(),
                // new LegoStarWarsTheCompleteSaga(), //! The input system seems to have other delays, which are incompatible with how the rest of the support games work.
                new LegoStarWarsTheForceAwakens(),
                // new LegoStarWarsTheSkywalkerSaga(), //! Uses on screen keyboard, which has some funky layout as well.
                new LegoStarWarsThreeTheCloneWars(),
                new LegoTheHobbit(),
                new LegoTheIncredibles(),
                // new LegoWorlds(), //! keyboard input system, rather than up and down arrows.
                // new TheLegoMovieTwoVideoGame(), //! Codes are input from writing on the keyboard itself, not just up and down.
                new TheLegoMovieVideoGame(), //? Only short cheat codes are supported.
                new TheLegoNinjagoMovieVideoGame(),
            };
    }
}
