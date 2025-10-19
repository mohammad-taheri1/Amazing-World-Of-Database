namespace BestTechU.Entities;

public class Professor : BaseEntity<long>
{
    public string Title { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string OfficePhone { get; set; } = default!;
    public string Email { get; set; } = default!;

    #region Collections

    public ICollection<Class> Classes { get; set; } = [];
    public ICollection<ProfessorCourseQualification> ProfessorCourseQualifications { get; set; } = [];

    #endregion

}
