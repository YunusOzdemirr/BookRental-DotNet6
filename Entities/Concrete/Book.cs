using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Book : EntityBase<int>, IEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public ICollection<BookAndCategory>? BookAndCategories { get; set; }
        public ICollection<BookPicture> BookPictures { get; set; }
    }
}

