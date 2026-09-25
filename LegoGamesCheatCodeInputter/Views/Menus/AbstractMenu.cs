namespace LegoGamesCheatCodeInputter.Views.Menus
{
    public abstract class AbstractMenu
    {
        private protected void RenderMenu(string[] menuItems, int selectedIndex)
        {
            Console.Clear();

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║          LEGO CHEAT CODE INPUTTER        ║");
            Console.WriteLine("╠══════════════════════════════════════════╣");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("║  Select a game:                          ║");
            Console.WriteLine("║                                          ║");

            for (int i = 0; i < menuItems.Length; i++)
            {
                string prefix = i == selectedIndex ? "> " : "  ";

                Console.WriteLine($"║  {prefix}{menuItems[i]}");
            }

            Console.WriteLine("║                                          ║");
            Console.WriteLine("║       ↑ ↓ Navigate   ENTER Select        ║");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
        }
    }
}
