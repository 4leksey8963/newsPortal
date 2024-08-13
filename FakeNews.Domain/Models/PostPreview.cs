namespace FakeNews.Domain.Models;

public class PostPreview : BaseEntity
{
    public Guid PostId { get; init; }
    public Link Image { get; protected set; } = null!;

    private PostPreview() {}

    public static PostPreview Create(Guid postId, Link image)
    {
        return new PostPreview()
        {
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Today,
            PostId = postId,
            Image = image
        };
    }
}