namespace BestTechU.Entities;

public class ProfessorCourseQualification : BaseEntity<long>
{
    public long CourseId { get; set; }
    public Course Course { get; set; } = new();
    public long ProfessorId { get; set; }
    public Professor Professor { get; set; } = new();

    #region Collections

    #endregion

}
