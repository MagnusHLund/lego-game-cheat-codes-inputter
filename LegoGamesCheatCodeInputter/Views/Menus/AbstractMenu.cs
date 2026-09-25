namespace LegoGamesCheatCodeInputter.Views.Menus
{
    public abstract class AbstractMenu
    {
        private protected void RenderMenu(string[] menuItems, int selectedIndex)
        {
            if (!Console.IsOutputRedirected)
                Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  LEGO  /  CHEAT CODE INPUTTER");
            Console.ResetColor();
            Console.WriteLine("  ─────────────────────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("  SELECT A GAME");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  Choose the game currently open on your screen.");
            Console.ResetColor();
            Console.WriteLine();

            for (int i = 0; i < menuItems.Length; i++)
            {
                bool selected = i == selectedIndex;
                Console.Write(selected ? "  ❯ " : "    ");
                if (selected)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  ↑ / ↓ Move     Enter Select     Esc Exit");
            Console.ResetColor();
        }
    }
}
