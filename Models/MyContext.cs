using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasKey(t => new { t.AuthotId, t.Book });

            modelBuilder.Entity<AuthorBook>()
                .HasOne(sc => sc.Author)
                .WithMany(s => s.AuthorBooks)
                .HasForeignKey(sc => sc.AuthotId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(sc => sc.Book)
                .WithMany(c => c.AuthorBooks)
                .HasForeignKey(sc => sc.BookId);
        }
    }
}
