using AppleBookDistributor.Domain.Entities;

namespace AppleBookDistributor.Domain.IServices;

public interface IAppleService
{
    AppleEntity? GetByIndex(Guid id);
    void DeleteByIndex(Guid id);
    List<AppleEntity> GetList();
    void Add(AppleEntity entity);
    void Update(AppleEntity entityToUpdate);
}