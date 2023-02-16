using System;

namespace BookStore.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Annotation { get; set; }
        public string PublishingHouse { get; set; }
        public string CoverType { get; set; }
        public int NumberOfPages { get; set; }
        public string Format { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public string Cover { get; set; }
        public int InStock { get; set; }

    }
}
