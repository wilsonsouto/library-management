using LibraryManagement.Enums;
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
                        AddBook();
                        break;
                    case MenuOptions.DeleteBook:
                        AnsiConsole.MarkupLine("You chose to delete a book. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AddBook()
        {
            Console.Write("Enter the book name: ");
            var book = Console.ReadLine();

            Console.Write("Enter the author's name: ");
            var author = Console.ReadLine();

            Console.Write("Enter the year of publication: ");
            var year = Console.ReadLine();

            Console.Write("Provide a brief description of the book: ");
            var description = Console.ReadLine();

            var genre = AnsiConsole.Prompt(
                new SelectionPrompt<BookGenre>()
                .Title("Select the book genre from the following options: ")
                .AddChoices(Enum.GetValues<BookGenre>()));
        }
    }
}
