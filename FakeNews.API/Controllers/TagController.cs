using FakeNews.API.Mocks;
using FakeNews.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FakeNews.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TagController(MockNewsStorage mockNewsStorage) : ControllerBase
{
    [HttpGet("tags")]
    public async Task<ActionResult<List<Tag>>> GetTags()
    {
        try
        {
            return await mockNewsStorage.GetTags();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}