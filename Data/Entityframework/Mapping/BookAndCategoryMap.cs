using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entityframework.Mapping
{
    public class BookAndCategoryMap : IEntityTypeConfiguration<BookAndCategory>
    {
        public void Configure(EntityTypeBuilder<BookAndCategory> builder)
        {
            builder.HasKey(a => new { a.BookId, a.CategoryId });
            builder.ToTable("BookAndCategories");
        }
    }
}