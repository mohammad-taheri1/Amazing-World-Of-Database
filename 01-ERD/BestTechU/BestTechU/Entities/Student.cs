using DownTownFloral;

namespace BestTechU.Entities;

public class Student : BaseEntity<long>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string Email { get; set; } = default!;
    public DateTime BirthDate { get; set; }

    #region Collections

    public ICollection<Enrollment> Enrollments { get; set; } = [];
    public ICollection<StudentAssignedToMajor> StudentAssignedToMajors { get; set; } = [];

    #endregion

}
