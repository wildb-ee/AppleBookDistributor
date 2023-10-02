using System.Linq.Expressions;
using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IRepositories;
using AppleBookDistributor.Domain.SeedWork;

namespace AppleBookDistributor.Infrastructure.Repositories;


public class AppleRepository : BaseRepository<AppleEntity>, IAppleRepository
{
    private static readonly List<AppleEntity> _database = new List<AppleEntity>()
    {
        new AppleEntity()
        {
            Id = Guid.NewGuid(),
            Color = "Black",
            Size = 50,
            Type = "Almaty"
        }
    };
      
    public AppleRepository() : base(_database)
    { }

    public override void Update(AppleEntity entityToUpdate)
    {
        var entity = this.Database.Find(item => item.Id == entityToUpdate.Id);
        if (entity == null)
        {
            throw new Exception();
        }
        
        entity.Color = entityToUpdate.Color;
        entity.Size = entityToUpdate.Size;
        entity.Type = entityToUpdate.Type;

    }
}