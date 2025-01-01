using EFCore_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreLearning;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var genreList = new List<Genre>
            {
                new Genre {GenreId = 1, GenreName = "Sci-Fi", DiplayOrder = 1},
                new Genre {GenreId = 2, GenreName = "Biography", DiplayOrder = 2},
                new Genre {GenreId = 3, GenreName = "Romance", DiplayOrder = 3},
                new Genre {GenreId = 4, GenreName = "Thriller", DiplayOrder = 4},
            };

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(x =>
            {
                x.Property(x => x.Price).HasPrecision(10, 5);
            });

            modelBuilder.Entity<Genre>(e =>
            {
                e.HasData(genreList);
                e.Property(m => m.GenreId).UseIdentityColumn();
            });

            modelBuilder.Entity<AuthorBook>().HasKey(x => new { x.BookId, x.AuthorId });
        }
    }
}
