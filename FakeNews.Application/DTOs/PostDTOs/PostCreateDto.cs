using FakeNews.Domain.Models;

namespace FakeNews.Application.DTOs.PostDTOs;

public record PostCreateDto(
    string Title,
    string Text,
    PostStatus PostStatus,
    Link Resource,
    ICollection<Link> Links,
    ICollection<Tag> PostTags);