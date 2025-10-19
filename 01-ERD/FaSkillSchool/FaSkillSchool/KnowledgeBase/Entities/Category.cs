using FaSkillSchool.Domain.QuestionBank.Entities;

namespace FaSkillSchool.Domain.KnowledgeBase.Entities;

public sealed class Category : BaseEntity<long>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    #region Collections

    public ICollection<Article> Articles { get; set; } = [];
    public ICollection<QuestionCategory> QuestionCategories { get; set; } = [];

    #endregion

}
