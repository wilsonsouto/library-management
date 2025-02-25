using LibraryManagement.Enums;
using Spectre.Console;

namespace LibraryManagement
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuOptions>()
                    .Title("What do you want to do next? ")
                    .AddChoices(Enum.GetValues<MenuOptions>()));

                switch (choice)
                {
                    case MenuOptions.ViewBooks:
                        AnsiConsole.MarkupLine("You chose to view books. Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case MenuOptions.AddBook:
                        AnsiConsole.MarkupLine("You chose to add a book. Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case MenuOptions.DeleteBook:
                        AnsiConsole.MarkupLine("You chose to delete a book. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }

                return;
            }
        }
    }
}