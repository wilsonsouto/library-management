using LibraryManagement.Enums;

namespace LibraryManagement.Models
{
    /// <summary>
    ///  Represents a model for a book with relevant details.
    /// </summary>
    /// <param name="title">The title of the book.</param>
    /// <param name="author">The author of the book.</param>
    /// <param name="year">The year the book was published.</param>
    /// <param name="description">A brief description about the book.</param>
    /// <param name="genre">The genre of the book.</param>
    public class BookModel(string title, string author, int year, string description, BookGenre genre)
    {
        public int Id { get; set; }

        public string Title { get; set; } = title;

        public string Author { get; set; } = author;

        public int Year { get; set; } = year;

        public string Description { get; set; } = description;

        public BookGenre Genre { get; set; } = genre;

    }
}
