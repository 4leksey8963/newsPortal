using static System.String;

namespace FakeNews.Domain.Models;

public class Post : BaseEntity
{
    public string Title { get; init; } = Empty;
    public string Text { get; init; } = Empty;
    public PostStatus PostStatus { get; set; } = PostStatus.Hidden;
    public Link Image { get; protected set; } = null!;
    public ICollection<Tag> Tags { get; protected set; } = null!;
    public Source Source { get; init; } = null!;
    private Post() {}
    
    public static Post Create(string title, string text, Link image, ICollection<Tag> tags, PostStatus postStatus, Source source)
    {
        return new Post()
        {
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Now,
            Title = title,
            Text = text,
            PostStatus = postStatus,
            Image = image,
            Source = source,
            Tags = tags
        };
    }
}