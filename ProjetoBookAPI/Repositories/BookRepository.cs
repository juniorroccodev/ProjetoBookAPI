using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoBookAPI.Model;

namespace ProjetoBookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }
        public async Task<Book> Create(Book book) //Criar um registro
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync(); //metodo async (permite fazer vários processamento ao mesmo tempo

            return book;
        }

        public async Task Delete(int id) //Deletar
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToListAsync(); 
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task Update(Book book) //Atualização
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        Task<Book> IBookRepository.Update(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}
