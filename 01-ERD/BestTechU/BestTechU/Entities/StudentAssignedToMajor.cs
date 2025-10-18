using BestTechU.Enums;

namespace BestTechU.Entities;

public class StudentAssignedToMajor : BaseEntity<long>
{
    public long StudentId { get; set; }
    public Student Student { get; set; } = new();
    public long MajorId { get; set; }
    public Major Major { get; set; } = new();
    public DateTime AssignmentDate { get; set; }
    public StudentAssignedToMajorStatus Status { get; set; }

    #region Collections

    #endregion

}
