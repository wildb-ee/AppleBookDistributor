using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AppleBookDistributor.Controllers;

public class BookController : ControllerBase
{
    private readonly IBookService _service;
    public BookController(IBookService service)
    {
        _service = service;
    }
    
    [HttpGet("GetAllBooks")]
    public List<BookEntity> GetAllBooks()
    {
        return _service.GetList();
    }
    
    [HttpGet("GetBookByIndex/{guid:guid}")]
    public BookEntity? GetBookByIndex(Guid guid)
    {
        return _service.GetByIndex(guid);
    }

    [HttpPost("AddBook")]
    public List<BookEntity> AddBook(string title, string author, string publisher)
    {
        var entity = new BookEntity() { Title = title, Author = author, Id = Guid.NewGuid(), Publisher = publisher };
        _service.Add(entity);
        return _service.GetList();
    }

    [HttpPatch("UpdateBook")]
    public List<BookEntity> UpdateBook(BookEntity entity)
    {
        _service.Update(entity);
        return _service.GetList();
    }

    [HttpDelete("DeleteBook")]
    public List<BookEntity> DeleteBook(Guid guid)
    {
        _service.DeleteByIndex(guid);
        return _service.GetList();
    }
}