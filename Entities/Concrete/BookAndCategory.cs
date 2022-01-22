using System;
namespace Entities.Concrete
{
    public class BookAndCategory
    {
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

