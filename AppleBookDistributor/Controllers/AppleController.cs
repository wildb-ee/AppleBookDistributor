using AppleBookDistributor.Domain.Entities;
using AppleBookDistributor.Domain.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AppleBookDistributor.Controllers;

public class AppleController : ControllerBase
{
    private readonly IAppleService _service;
    public AppleController(IAppleService service)
    {
        _service = service;
    }
    
    [HttpGet("GetAllApples")]
    public List<AppleEntity> GetAllApples()
    {
        return _service.GetList();
    }
    
    [HttpGet("GetAppleByIndex/{guid:guid}")]
    public AppleEntity? GetAppleByIndex(Guid guid)
    {
        return _service.GetByIndex(guid);
    }

    [HttpPost("AddApple")]
    public List<AppleEntity> AddApple(string type, long size, string color)
    {
        var entity = new AppleEntity() { Type = type, Color = color, Id = Guid.NewGuid(), Size = size };
        _service.Add(entity);
        return _service.GetList();
    }

    [HttpPatch("UpdateApple")]
    public List<AppleEntity> UpdateApple(AppleEntity entity)
    {
        _service.Update(entity);
        return _service.GetList();
    }

    [HttpDelete("DeleteApple")]
    public List<AppleEntity> DeleteApple(Guid guid)
    {
        _service.DeleteByIndex(guid);
        return _service.GetList();
    }
    
}