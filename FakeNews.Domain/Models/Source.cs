using static System.String;

namespace FakeNews.Domain.Models;

public class Source : BaseEntity
{
    public string Name { get; protected set; } = Empty;
    public SourceChannel SourceChannel { get; protected set; } = null!;
    public bool IsActivated { get; protected set; }
    
    private Source(){}
    
    public static Source Create(string name, SourceChannel sourceChannel, bool isActivated)
    {
        return new Source()
        {
            Name = name,
            SourceChannel = sourceChannel,
            IsActivated = isActivated
        };
    }
}