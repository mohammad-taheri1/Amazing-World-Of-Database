namespace BestTechU.Entities;

public class Major : BaseEntity<long>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    #region Collections

    public ICollection<CourseToMajor> CourseToMajors { get; set; } = [];
    public ICollection<StudentAssignedToMajor> StudentAssignedToMajors { get; set; } = [];

    #endregion

}
