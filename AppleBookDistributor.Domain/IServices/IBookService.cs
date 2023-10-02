using AppleBookDistributor.Domain.Entities;

namespace AppleBookDistributor.Domain.IServices;

public interface IBookService
{
    BookEntity? GetByIndex(Guid id);
    void DeleteByIndex(Guid id);
    List<BookEntity> GetList();
    void Add(BookEntity entity);
    void Update(BookEntity entityToUpdate);    
}