using FakeNews.Domain.Models;

namespace FakeNews.Application.DTOs.PostPreviewDTOs;

public record PostPreviewDto(Guid Id, Guid PostId, string Title, ICollection<Tag> Tags);