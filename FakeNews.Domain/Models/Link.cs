using static System.String;

namespace FakeNews.Domain.Models;

public class Link : BaseEntity
{
    public string Address { get; init; } = Empty;
    
    private Link() {}

    public static Link Create(string address)
    {
        return new Link()
        {
            CreateDate = DateTime.Now,
            Id = Guid.NewGuid(),
            Address = address
        };
    }
}