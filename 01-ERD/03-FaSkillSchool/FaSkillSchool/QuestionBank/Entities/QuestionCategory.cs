using FaSkillSchool.Domain.KnowledgeBase.Entities;

namespace FaSkillSchool.Domain.QuestionBank.Entities;

public sealed class QuestionCategory : BaseEntity<long>
{
    public long QuestionId { get; set; }
    public Question Question { get; set; } = new();
    public long CategoryId { get; set; }
    public Category Category { get; set; } = new();

    #region Collections

    #endregion

}
