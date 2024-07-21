using BookStore.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistence
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }
    }
}
