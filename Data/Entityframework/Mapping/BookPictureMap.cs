using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entityframework.Mapping
{
    public class BookPictureMap : IEntityTypeConfiguration<BookPicture>
    {
        public void Configure(EntityTypeBuilder<BookPicture> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.BookId).IsRequired();
            builder.Property(a => a.File).IsRequired();
            builder.HasOne<Book>(a => a.Book).WithMany(a =>a.BookPictures).HasForeignKey(a => a.BookId);
            builder.ToTable("BookPictures");
                



        }
    }
}
