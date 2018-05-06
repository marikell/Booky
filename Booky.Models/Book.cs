namespace Booky.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string BookPublisher { get; set; }
        public string Author { get; set; }
        public int StockQty { get; set; }
    }
}
