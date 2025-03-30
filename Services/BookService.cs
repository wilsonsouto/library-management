using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    /// <summary>
    /// Provides methods for managing a collection of books, including adding new books and retrieving all stored books.
    /// </summary>
    public class BookService
    {
        /// <summary>
        /// A list containing all the books.
        /// </summary>
        private static readonly List<BookModel> books = [];

        /// <summary>
        ///  Stores the current book ID, which is automatically incremented whenever the 'AddBook' method is called.
        /// </summary>
        private static int currentId = 1;

        /// <summary>
        /// Adds a new book to the books list and assigns it a unique ID.
        /// </summary>
        /// <param name="book">An instance of <see cref="BookModel"/> containing the book details provided by the user.</param>
        public static void AddBook(BookModel book)
        {
            book.Id = currentId;
            books.Add(book);
            currentId++;
        }

        /// <summary>
        /// Retrieve all the books stored in books list.
        /// </summary>
        /// <returns><see cref="books"/></returns>
        public static List<BookModel> GetAllBooks() => books;
    }
}

