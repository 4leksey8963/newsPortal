using FakeNews.Domain.Models;

namespace FakeNews.Application.DTOs.PostPreviewDTOs;

public record PostPreviewCreateDto(Guid PostId, ICollection<Tag> PostTags);