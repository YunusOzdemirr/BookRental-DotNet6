using System;
using Data.Entityframework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Entityframework.Context
{
    public class BookRentalContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAndCategory> BookAndCategories { get; set; }
        public DbSet<BookPicture> BookPictures { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new BookPictureMap());
            modelBuilder.ApplyConfiguration(new BookAndCategoryMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost;Database=BookRental;User=sa;Password=Password123@jkl#;");
        }

    }
}

