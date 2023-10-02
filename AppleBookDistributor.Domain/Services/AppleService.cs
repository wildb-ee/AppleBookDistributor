using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IRepositories;
using AppleBookDistributor.Domain.IServices;

namespace AppleBookDistributor.Domain.Services;

public class AppleService : IAppleService
{
    private readonly IAppleRepository _appleRepository;

    public AppleService(IAppleRepository appleRepository)
    {
        _appleRepository = appleRepository;
    }
    
    public AppleEntity? GetByIndex(Guid id)
    {
        return _appleRepository.GetByIndex(id);
    }

    public void DeleteByIndex(Guid id)
    {
        _appleRepository.DeleteByIndex(id);
    }

    public List<AppleEntity> GetList()
    {
        return _appleRepository.GetList();
    }

    public void Add(AppleEntity entity)
    {
        _appleRepository.Add(entity);
    }

    public void Update(AppleEntity entityToUpdate)
    {
        _appleRepository.Update(entityToUpdate);
    }
}