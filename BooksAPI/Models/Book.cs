namespace BooksAPI.Models
{
	public class Book
	{
        public int Id { get; set; }
        /// <summary>
        /// Book title
        /// </summary>
        public string Title { get; set; } = "";
        /// <summary>
        /// Book authour
        /// </summary>
        public string Author { get; set; } = "";
    }
}

