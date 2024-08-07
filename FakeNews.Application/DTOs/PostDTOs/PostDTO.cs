using FakeNews.Domain.Models;

namespace FakeNews.Application.DTOs.PostDTOs;

public record PostDto(
    Guid Id,
    string Title,
    string Text,
    PostStatus PostStatus,
    ICollection<Link> Links,
    Link Resource, 
    ICollection<Tag> Tags);