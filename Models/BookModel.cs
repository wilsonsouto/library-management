namespace LibraryManagement.Models
{
    public class BookModel(string name, string author, int year, string description, string genre)
    {
        public string Book { get; set; } = name;

        public string Author { get; set; } = author;

        public int Year { get; set; } = year;

        public string Description { get; set; } = description;

        public string Genre { get; set; } = genre;

    }
}
