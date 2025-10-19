namespace FaSkillSchool.Domain.Interview.Entities;

public sealed class SessionResult : BaseEntity<long>
{
    public long InterviewSessionId { get; set; }
    public InterviewSession InterviewSession { get; set; } = new();
    public int CorrectAnswers { get; set; }
    public double Score { get; set; }

    #region Collections

    #endregion

}
