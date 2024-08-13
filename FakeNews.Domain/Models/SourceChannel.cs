using static System.String;

namespace FakeNews.Domain.Models;

public class SourceChannel : BaseEntity
{
    public string Name { get; protected set; } = Empty;
    public Link SourceLink { get; private set; } = null!;
    
    private SourceChannel(){}
    
    public static SourceChannel Create(string name, Link link)
    {
        return new SourceChannel()
        {
            Name = name,
            SourceLink = link,
        };
    }
}