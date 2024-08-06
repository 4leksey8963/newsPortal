namespace FakeNews.Domain.Models;

public class BaseEntity : IEntity
{
    public Guid Id { get; protected set; }
    
    public DateTime CreateDate { get; protected set; }
    public DateTime UpdateDate { get; protected set; }
    public DateTime DeleteDate { get; protected set; }
}