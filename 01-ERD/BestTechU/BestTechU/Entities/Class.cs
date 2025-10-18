using DownTownFloral;

namespace BestTechU.Entities;

public class Class : BaseEntity<long>
{
    public long CourseId { get; set; }
    public Course Course { get; set; } = new();
    public long SemesterId { get; set; }
    public Semester Semester { get; set; } = new();
    public long Section { get; set; }
    public int Room { get; set; }
    public int Capacity { get; set; }

    #region Collections

    public ICollection<Enrollment> Enrollments { get; set; } = [];

    #endregion

}