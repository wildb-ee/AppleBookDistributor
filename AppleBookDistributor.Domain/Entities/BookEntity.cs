using AppleBookDistributor.Domain.SeedWork;

namespace AppleBookDistributor.Domain.Entities;

public class BookEntity : Entity, IAggregateRoot
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }    
}