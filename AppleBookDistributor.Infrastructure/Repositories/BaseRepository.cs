using AppleBookDistributor.Domain.SeedWork;

namespace AppleBookDistributor.Infrastructure.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T: Entity, IAggregateRoot
{
    protected List<T> Database;

    public BaseRepository(List<T> database)
    {
        Database = database.ToList();
    }
    public T? GetByIndex(Guid id)
    {
        return Database.Find(item => item.Id == id);
    }

    public void DeleteByIndex(Guid id)
    {
        var element = this.GetByIndex(id);
        if (element == null || Database.Count == 0)
        {
            throw new Exception();
        }
        Database.Remove(element);
    }

    public List<T> GetList()
    {
        return Database;
    }

    public void Add(T entity)
    {
        Database.Add(entity);
    }

    public abstract void Update(T entityToUpdate);
}