using System.Linq.Expressions;
using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IRepositories;

namespace AppleBookDistributor.Infrastructure.Repositories;

public class BookRepository : BaseRepository<BookEntity>, IBookRepository
{
    private static readonly List<BookEntity> _database = new List<BookEntity>()
    {
        new BookEntity()
        {
            Id = Guid.NewGuid(),
            Title = "Vadim",
            Publisher = "London Book Society",
            Author = "Lermotov"
        }
    };
      
    public BookRepository() : base(_database)
    { }

    public override void Update(BookEntity entityToUpdate)
    {
        var entity = this.Database.Find(item => item.Id == entityToUpdate.Id);
        if (entity == null)
        {
            throw new Exception();
        }
        
        entity.Author = entityToUpdate.Author;
        entity.Title = entityToUpdate.Title;
        entity.Publisher = entityToUpdate.Publisher;
    }
}