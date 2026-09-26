using System.Text.Json;

namespace LegoGamesCheatCodeInputter.Configuration
{
    public sealed class AppSettings
    {
        public InputSettingsOptions Input { get; init; } = new();
        public int FocusCountdownSeconds { get; init; } = 5;

        public static AppSettings Load(string? filePath = null)
        {
            filePath ??= Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            if (!File.Exists(filePath))
                return new AppSettings();

            AppSettings settings;
            try
            {
                settings =
                    JsonSerializer.Deserialize<AppSettings>(
                        File.ReadAllText(filePath),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    ) ?? throw new InvalidDataException("The settings file is empty or invalid.");
            }
            catch (JsonException exception)
            {
                throw new InvalidDataException(
                    $"Could not read settings file '{filePath}'.",
                    exception
                );
            }

            settings.Validate();
            return settings;
        }

        private void Validate()
        {
            if (Input is null)
                throw new InvalidDataException("The Input settings section is required.");

            ValidateDelay(
                nameof(Input.KeyHoldDurationMilliseconds),
                Input.KeyHoldDurationMilliseconds
            );
            ValidateDelay(nameof(Input.KeyEventDelayMilliseconds), Input.KeyEventDelayMilliseconds);
            ValidateDelay(
                nameof(Input.CharacterSelectionDelayMilliseconds),
                Input.CharacterSelectionDelayMilliseconds
            );
            ValidateDelay(
                nameof(Input.CodeSubmitDelayMilliseconds),
                Input.CodeSubmitDelayMilliseconds
            );

            if (FocusCountdownSeconds is < 0 or > 60)
                throw new InvalidDataException("FocusCountdownSeconds must be between 0 and 60.");
        }

        private static void ValidateDelay(string name, int value)
        {
            if (value is < 0 or > 60000)
                throw new InvalidDataException($"{name} must be between 0 and 60000 milliseconds (60 seconds).");
        }
    }
}
