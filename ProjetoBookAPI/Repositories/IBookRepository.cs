using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoBookAPI.Model;

namespace ProjetoBookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int id); //Consulta

        Task<Book> Create(Book book);

        Task<Book> Update(Book book);

        Task Delete(int id); //Deletar
    }
}
