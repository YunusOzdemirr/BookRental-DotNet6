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
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Name).HasMaxLength(20);
            builder.Property(a => a.PageCount).IsRequired();
            builder.HasOne<Customer>(a => a.Customer).WithMany(a => a.Books).HasForeignKey(a => a.CustomerId);
            builder.ToTable("Books");
        }
    }
}
