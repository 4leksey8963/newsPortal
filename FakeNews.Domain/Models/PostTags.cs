namespace FakeNews.Domain.Models;

public class PostTags : BaseEntity
{
    public ICollection<Tag> Tags { get; protected set; } = new List<Tag>();
    
    private PostTags(){}

    public static PostTags Create(ICollection<Tag> tags)
    {
        return new PostTags()
        {
            Tags = tags,
        };
    }
}