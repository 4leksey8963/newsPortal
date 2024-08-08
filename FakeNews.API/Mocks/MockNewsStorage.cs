using System.Globalization;
using FakeNews.Application.DTOs.PostDTOs;
using FakeNews.Application.DTOs.PostPreviewDTOs;
using FakeNews.Domain.Models;

namespace FakeNews.API.Mocks;

public class MockNewsStorage
{
    private readonly List<Tag> _tags;
    private readonly List<PostDto> _posts;
    private readonly List<PostPreviewDto> _postPreviews;
    
    public MockNewsStorage()
    {
        _tags = CreateTags(12);
        _posts = CreatePosts(40, _tags);
        _postPreviews = CreatePreviews(_posts);
    }

    public Task<List<Tag>> GetTags()
    {
        return Task.FromResult(_tags);
    }
    
    public Task<PostDto> GetPostById(Guid id)
    {
        var res = _posts.First(e => e.Id == id);
        return Task.FromResult(res);
    }

    public Task<List<PostPreviewDto>> GetPagePreviews(int page = 1, int size = 5)
    {
        return Task.FromResult(_postPreviews.Skip(page * size).Take(size).ToList());
    }

    public Task<List<PostPreviewDto>> GetPagePreviewsByTags(int page, int size, List<Guid> tagsIds)
    {   
        var res = _postPreviews
            .Where(preview => preview.Tags
            .Any(tag => tagsIds.Contains(tag.Id)))
            .ToList();
        return Task.FromResult(res);
    }

    private static List<Tag> CreateTags(int count)
    {
        List<Tag> res = [];
        for (var i = 0; i < count; i++)
        {
            var tag = Tag.Create("tag" + i);
            res.Add(tag);
        }

        return res;
    }

    private static List<PostDto> CreatePosts(int count, List<Tag> tags)
    {
        var text = "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n" +
                   "Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help? Need help?\n";

        var title = "Need help?";

        List<PostDto> res = [];

        var rand = new Random();
        
        for (var i = 0; i < count; i++)
        {
            title += i;
            text += i;
            res.Add(new PostDto(Guid.NewGuid(), title, text, PostStatus.Available, [Link.Create("link")],  Link.Create("link"), tags.Take(rand.Next(tags.Count)).ToList()));
        }

        return res;
    }

    private static List<PostPreviewDto> CreatePreviews(List<PostDto> posts)
    {
        var previews = from post in posts
            select new PostPreviewDto(post.Id, post.Id, post.Title, post.Tags);
        
        return previews.ToList();
    }
}