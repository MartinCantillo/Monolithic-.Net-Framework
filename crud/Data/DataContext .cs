
using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autors { set; get; }
        public DbSet<Book> Books { set; get; }
    }
}