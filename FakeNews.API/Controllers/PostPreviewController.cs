using FakeNews.API.Mocks;
using FakeNews.Application.DTOs.PostPreviewDTOs;
using Microsoft.AspNetCore.Mvc;

namespace FakeNews.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostPreviewController(MockNewsStorage mockNewsStorage) : ControllerBase
{
    [HttpGet("page")]
    public async Task<ActionResult<List<PostPreviewDto>>> GetPagePreviews(int page = 1, int size = 5)
    {
        try
        {
            return await mockNewsStorage.GetPagePreviews(page, size);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("tags")]
    public async Task<ActionResult<List<PostPreviewDto>>> GetPagePreviewsByTags( List<Guid> tagsIds, int page = 1, int size = 5)
    {
        try
        {
            return await mockNewsStorage.GetPagePreviewsByTags(page, size, tagsIds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}