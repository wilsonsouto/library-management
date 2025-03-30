using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class BookService
    {
        private static readonly List<BookModel> books = [];
        
        private static int currentId = 1;
        
        public static void AddBook(BookModel book)
        {
            book.Id = currentId;
            books.Add(book);
            currentId++;
        }

        public static List<BookModel> GetAllBooks() => books;
    }

}

