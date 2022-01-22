using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class BookPicture : EntityBase<int>, IEntity
    {
        public byte[] File { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

