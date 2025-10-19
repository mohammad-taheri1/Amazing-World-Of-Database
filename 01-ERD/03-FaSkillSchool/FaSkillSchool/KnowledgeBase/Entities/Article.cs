using FaSkillSchool.Domain.Identity.Entities;

namespace FaSkillSchool.Domain.KnowledgeBase.Entities;

public sealed class Article : BaseEntity<long>
{
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public long CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public long AuthorId { get; set; }
    public AppUser Author { get; set; } = new();

    #region Collections

    #endregion

}
