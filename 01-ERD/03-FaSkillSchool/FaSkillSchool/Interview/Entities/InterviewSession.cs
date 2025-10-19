using FaSkillSchool.Domain.Identity.Entities;

namespace FaSkillSchool.Domain.Interview.Entities;

public sealed class InterviewSession : BaseEntity<long>
{
    public long CandidateId { get; set; }
    public AppUser Candidate { get; set; } = new();
    public long SessionResultId { get; set; }
    public SessionResult SessionResult { get; set; } = new();
    public string Title { get; set; } = default!;
    public int TotalQuestions { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    #region Collections

    public ICollection<UserAnswer> UserAnswers { get; set; } = [];

    #endregion

}
