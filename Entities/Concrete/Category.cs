using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : EntityBase<int>, IEntity
    {
        public string Name { get; set; }
        public ICollection<BookAndCategory>? BookAndCategories { get; set; }
    }
}

