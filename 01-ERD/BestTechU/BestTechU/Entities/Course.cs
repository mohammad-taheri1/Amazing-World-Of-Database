using DownTownFloral;

namespace BestTechU.Entities;

public class Course : BaseEntity<long>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;

    #region Collections

    public ICollection<Class> Classes { get; set; } = [];
    public ICollection<CourseToMajor> CourseToMajors { get; set; } = [];

    #endregion

}
