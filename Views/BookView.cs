using LibraryManagement.Enums;
using LibraryManagement.Models;
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
                        var books = BookService.GetAllBooks();
                        ViewBooks(books);
                        AnsiConsole.MarkupLine("Press any key to get back to the menu.");
                        break;
                    case MenuOptions.AddBook:
                        var userInput = GetBookInput();
                        BookService.AddBook(userInput);
                        AnsiConsole.MarkupLine("New book added. Press any key to get back to the menu.");
                        break;
                    case MenuOptions.DeleteBook:
                        AnsiConsole.MarkupLine("You chose to delete a book. Press any key to get back to the menu");
                        Console.ReadKey();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static BookModel GetBookInput()
        {
            Console.Write("Enter the book name: ");
            var book = Console.ReadLine();

            Console.Write("Enter the author's name: ");
            var author = Console.ReadLine();

            Console.Write("Enter the year of publication: ");
            var year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Provide a brief description of the book: ");
            var description = Console.ReadLine();

            var genre = AnsiConsole.Prompt(
                new SelectionPrompt<BookGenre>()
                .Title("Select the book genre from the following options: ")
                .AddChoices(Enum.GetValues<BookGenre>()));

            return new BookModel(book, author, year, description, genre);
        }

        private static void ViewBooks(List<BookModel> books)
        {
            var table = new Table();
            table.AddColumn("Id");
            table.AddColumn("Book");
            table.AddColumn("Author");
            table.AddColumn("Year of publication");
            table.AddColumn("Description");
            table.AddColumn("Genre");

            foreach (BookModel book in books)
            {
                table.AddRow(
                    book.Id.ToString(),
                    book.Title,
                    book.Author,
                    book.Year.ToString(),
                    book.Description,
                    book.Genre.ToString()
                );

            }

            table.Border(TableBorder.Rounded);
            AnsiConsole.Write(table);
        }
    }
}
