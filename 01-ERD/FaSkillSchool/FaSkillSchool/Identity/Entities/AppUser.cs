using FaSkillSchool.Domain.Interview.Entities;
using FaSkillSchool.Domain.KnowledgeBase.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaSkillSchool.Domain.Identity.Entities;

public sealed class AppUser : BaseEntity<Guid>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;

    [NotMapped]
    public string? DisplayName => FirstName + " " + LastName;

    #region Collections

    #region Collections

    public ICollection<AppUserRole> AppUserRoles { get; set; } = [];
    public ICollection<Article> Articles { get; set; } = [];
    public ICollection<InterviewSession> InterviewSessions { get; set; } = [];

    #endregion

    #endregion

}
