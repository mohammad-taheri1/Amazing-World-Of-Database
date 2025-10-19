namespace FaSkillSchool.Domain.Identity.Entities;

public sealed class AppUserRole : BaseEntity<long>
{
    public long UserId { get; set; }
    public AppUser AppUser { get; set; } = new();
    public long RoleId { get; set; }
    public AppRole AppRole { get; set; } = new();

    #region Collections

    #endregion

}
