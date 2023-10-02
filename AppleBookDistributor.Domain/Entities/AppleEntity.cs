using System.Collections;
using System.Drawing;
using AppleBookDistributor.Domain.SeedWork;

namespace AppleBookDistributor.Domain.Entities;

public class AppleEntity : Entity, IAggregateRoot
{
    public string Type { get; set; }
    public long Size { get; set; }
    public string Color { get; set; }
}