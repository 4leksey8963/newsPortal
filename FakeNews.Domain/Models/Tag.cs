using static System.String;

namespace FakeNews.Domain.Models;

public class Tag : BaseEntity
{
    public string Name { get; init; } = Empty;
    
    private Tag() {}

    public static Tag Create(string name)
    {
        return new Tag()
        {
            Name = name,
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Now,
        };
    } 
}