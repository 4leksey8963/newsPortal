namespace FakeNews.Domain.Models;

public class PostPreview : BaseEntity
{
    public Guid PostId { get; init; }
    public PostTags PostTags { get; init; } = null!;

    private PostPreview() {}

    public static PostPreview Create(Guid postId, PostTags postTags)
    {
        return new PostPreview()
        {
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Today,
            PostId = postId,
            PostTags = postTags,
        };
    }
}