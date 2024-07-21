using BookStore.Core.Models;

namespace BookStore.Persistence.Repositories
{
    public interface IBooksRepositories
    {
        Task<Guid> Create(Book book);
        Task<Guid> Delete(Guid id);
        Task<List<Book>> Get();
        Task<Guid> Update(Guid id, string title, string description, uint price);
    }
}