using LibraryManagement.Enums;
using LibraryManagement.Services;
using Spectre.Console;

namespace LibraryManagement.Views
{
    public class BookView
    {
        public static void RunMenu()
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
                        BookService.AddBook();
                         break;
                    case MenuOptions.DeleteBook:
                        AnsiConsole.MarkupLine("You chose to delete a book. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
