# LEGO Games Cheat Code Inputter

Enter cheat codes in supported PC LEGO games without typing each one by hand. Choose the game, open its code-entry screen, and let the app navigate the characters for you.

**[Download the latest version from the website](https://brickcodes.magnuslund.com)** — it automatically recommends the right release for your platform.

## For Players

### Download

Prebuilt downloads are intended to be available from [GitHub Releases](https://github.com/MagnusHLund/lego-game-cheat-codes-inputter/releases). Choose the package that matches your operating system and CPU architecture.

A self-contained release includes the .NET runtime, so you do not need to install the .NET SDK or runtime. Releases must be built separately for each supported platform. If there is no release package available yet, see [For Developers](#for-developers) to run the app from source.

Windows releases are unsigned. Windows may show a Microsoft Defender SmartScreen warning because the publisher is unverified. Only download releases from this repository or [the website](https://brickcodes.magnuslund.com).

### Use the app

1. Start the game and open its **Enter Code** screen.
2. Make sure the game is ready to accept a code, all six characters are set to `A`, and the first character position is selected.
3. Start the inputter and choose the matching game with **Up** and **Down**. Press **Enter** to select it, or **Escape** to exit.
4. Press Enter at the prompt to begin the countdown, then switch focus to the game before it ends.
5. Leave the game focused and avoid using the keyboard until the inputter finishes.

The app moves through characters with **Up** and **Down**, advances between character positions with **Right**, and submits each code with **Enter**. Check the game afterward to confirm it accepted the codes.

### Supported games

These are the games currently available in the app. Games that use a different code-entry system are not included.

- LEGO Batman: The Video Game
- LEGO Batman 2: DC Super Heroes
- LEGO Batman 3: Beyond Gotham
- LEGO Harry Potter: Years 1–4
- LEGO Harry Potter: Years 5–7
- LEGO Indiana Jones: The Original Adventures
- LEGO Indiana Jones 2: The Adventure Continues
- LEGO Jurassic World
- LEGO Lord of the Rings
- LEGO Marvel Avengers
- LEGO Marvel Super Heroes
- LEGO Marvel Super Heroes 2
- LEGO Pirates of the Caribbean: The Video Game
- LEGO Star Wars: The Complete Saga
- LEGO Star Wars: The Force Awakens
- LEGO Star Wars: The Video Game
- LEGO Star Wars III: The Clone Wars
- LEGO Star Wars II: The Original Trilogy
- LEGO The Hobbit
- The LEGO Ninjago Movie Video Game

### Report missing cheat codes

Found a missing or incorrect code? [Open an issue](https://github.com/MagnusHLund/lego-game-cheat-codes-inputter/issues/new) with the game title, code, what it unlocks, and a source or other evidence so it can be verified.

You can also contribute the change directly: [fork the repository](https://github.com/MagnusHLund/lego-game-cheat-codes-inputter/fork), add or correct the entry in the matching game file under `LegoGamesCheatCodeInputter/Models/Games/`, then open a pull request from your fork. Include the source or evidence for the code in the pull request description.

Keyboard simulation is provided by SharpHook. macOS may require Accessibility permission. On Linux, support and permissions depend on the input backend and desktop session; Wayland may have additional limitations.

## For Developers

### Requirements

- .NET 10 SDK
- A supported desktop environment to try real keyboard simulation

### Build and run

From the repository root:

```sh
dotnet build LegoGamesCheatCodeInputter/LegoGamesCheatCodeInputter.csproj
dotnet run --project LegoGamesCheatCodeInputter/LegoGamesCheatCodeInputter.csproj
```

### Run tests

```sh
dotnet test LegoGamesCheatCodeInputter.Tests/LegoGamesCheatCodeInputter.Tests.csproj
```

The tests use fake keyboard and timing providers. They do not send keystrokes to a game or wait through real delays.

### Publish a self-contained build

Publish separately for each target operating system and CPU architecture. For example, to publish for 64-bit Windows:

```sh
dotnet publish LegoGamesCheatCodeInputter/LegoGamesCheatCodeInputter.csproj \
  --configuration Release \
  --runtime win-x64 \
  --self-contained true
```

Replace `win-x64` with the appropriate .NET runtime identifier for the target platform, such as `linux-x64`, `osx-x64`, or `osx-arm64`. Distribute the complete publish output, including `appsettings.json`. Self-contained builds bundle the .NET runtime, but remain platform-specific. [Microsoft's .NET publishing guide](https://learn.microsoft.com/dotnet/core/deploying/) has more details.

### Configuration

The app reads `appsettings.json` from its application directory. When building from source, edit `LegoGamesCheatCodeInputter/appsettings.json`; it is copied to the build output. For a published package, keep the settings file next to the executable. If the file is missing, the app uses these defaults:

```json
{
  "Input": {
    "KeyHoldDurationMilliseconds": 60,
    "KeyEventDelayMilliseconds": 60,
    "CharacterSelectionDelayMilliseconds": 120,
    "CodeSubmitDelayMilliseconds": 120
  },
  "FocusCountdownSeconds": 5
}
```

| Setting                               | Default | Meaning                                                                     |
| ------------------------------------- | ------: | --------------------------------------------------------------------------- |
| `KeyHoldDurationMilliseconds`         |    `60` | How long each simulated key is held before release.                         |
| `KeyEventDelayMilliseconds`           |    `60` | Pause after releasing each simulated key.                                   |
| `CharacterSelectionDelayMilliseconds` |   `120` | Pause after choosing a character and before advancing to the next position. |
| `CodeSubmitDelayMilliseconds`         |   `120` | Pause after submitting a code.                                              |
| `FocusCountdownSeconds`               |     `5` | Time to focus the game before code entry starts.                            |

Delay settings accept `0`–`60000` milliseconds. `FocusCountdownSeconds` accepts `0`–`60`. Invalid settings are reported when the app starts. Increase `KeyHoldDurationMilliseconds` if a game misses simulated presses; the other delays control pacing between inputs.
