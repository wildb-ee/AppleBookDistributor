using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IRepositories;
using AppleBookDistributor.Domain.IServices;

namespace AppleBookDistributor.Domain.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public BookEntity? GetByIndex(Guid id)
    {
        return _bookRepository.GetByIndex(id);
    }

    public void DeleteByIndex(Guid id)
    {
        _bookRepository.DeleteByIndex(id);
    }

    public List<BookEntity> GetList()
    {
        return _bookRepository.GetList();
    }

    public void Add(BookEntity entity)
    {
        _bookRepository.Add(entity);
    }

    public void Update(BookEntity entityToUpdate)
    {
        _bookRepository.Update(entityToUpdate);
    }
}