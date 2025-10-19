using FaSkillSchool.Domain.Interview.Entities;

namespace FaSkillSchool.Domain.QuestionBank.Entities;

public sealed class QuestionOption : BaseEntity<long>
{
    public long QuestionId { get; set; }
    public Question Question { get; set; } = new();
    public string OptionText { get; set; } = default!;
    public bool IsCorrect { get; set; }

    #region Collections

    public ICollection<UserAnswer> UserAnswers { get; set; } = [];

    #endregion

}
