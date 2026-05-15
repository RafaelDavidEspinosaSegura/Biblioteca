

namespace aplication.Interfaces
{
    public interface IBookRepository
    {
       Task<Book> AddAsync(Book book);
       Task<Book> GetByIdAsync(int id);
       Task<IEnumerable<Book>> GetAllAsync();
       Task UpdateAsync(Book book);
       Task deleteAsnyc(int id);
    }
}