namespace FaSkillSchool.Domain.Identity.Entities;

public sealed class AppRole : BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }


    #region Collections

    public ICollection<AppUserRole> AppUserRoles { get; set; } = [];

    #endregion

}
