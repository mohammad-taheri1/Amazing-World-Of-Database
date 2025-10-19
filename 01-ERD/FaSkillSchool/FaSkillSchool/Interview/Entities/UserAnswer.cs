using FaSkillSchool.Domain.QuestionBank.Entities;

namespace FaSkillSchool.Domain.Interview.Entities;

public sealed class UserAnswer : BaseEntity<long>
{
    public long InterviewSessionId { get; set; }
    public InterviewSession InterviewSession { get; set; } = new();
    public long QuestionId { get; set; }
    public Question Question { get; set; } = new();
    public long SelectedOptionId { get; set; }
    public QuestionOption SelectedOption { get; set; } = new();
    public bool IsCorrect { get; set; }

    #region Collections

    #endregion

}
