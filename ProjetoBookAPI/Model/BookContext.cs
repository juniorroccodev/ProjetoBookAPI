using Microsoft.EntityFrameworkCore;

namespace ProjetoBookAPI.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions <BookContext>options) : base(options)
        {
            Database.EnsureCreated(); //Cria a base de Dados
        }

        public DbSet<Book> Books { get; set; }
    }
}
