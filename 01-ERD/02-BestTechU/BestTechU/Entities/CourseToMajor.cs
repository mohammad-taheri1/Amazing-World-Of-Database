namespace BestTechU.Entities;

public class CourseToMajor : BaseEntity<long>
{
    public long CourseId { get; set; }
    public Course Course { get; set; } = new();
    public long MajorId { get; set; }
    public Major Major { get; set; } = new();

    #region Collections

    #endregion

}
