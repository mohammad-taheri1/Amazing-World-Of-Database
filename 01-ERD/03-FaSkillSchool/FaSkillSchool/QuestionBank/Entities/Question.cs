using FaSkillSchool.Domain.Identity.Entities;
using FaSkillSchool.Domain.Interview.Entities;

namespace FaSkillSchool.Domain.QuestionBank.Entities;

public sealed class Question : BaseEntity<long>
{
    public string Text { get; set; } = default!;
    public string? Explanation { get; set; }
    public long AuthorId { get; set; }
    public AppUser Author { get; set; } = new();
    public int OptionsCount { get; set; } = 4;

    #region Collections

    public ICollection<QuestionOption> QuestionOptions { get; set; } = [];
    public ICollection<QuestionCategory> QuestionCategories { get; set; } = [];
    public ICollection<UserAnswer> UserAnswers { get; set; } = [];

    #endregion

}
