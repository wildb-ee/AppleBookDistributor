using System.Linq.Expressions;

namespace AppleBookDistributor.Domain.SeedWork;

public interface IRepository<TEntity>
    where TEntity : Entity, IAggregateRoot
{
    TEntity? GetByIndex(Guid id);
    void DeleteByIndex(Guid id);

    List<TEntity> GetList();
    void Add(TEntity entity);
    void Update(TEntity entityToUpdate);
}