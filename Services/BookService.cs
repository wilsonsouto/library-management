using LibraryManagement.Enums;
using LibraryManagement.Models;
using Spectre.Console;

namespace LibraryManagement.Services
{
    class BookService
    {
        public static BookModel AddBook()
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
    }

}

