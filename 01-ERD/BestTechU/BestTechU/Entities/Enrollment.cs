using DownTownFloral;

namespace BestTechU.Entities;

public class Enrollment : BaseEntity<long>
{
    public long ClassId { get; set; }
    public Class Class { get; set; } = new();
    public long StudentId { get; set; }
    public Student Student { get; set; } = new();
    public DateTime RegisterDate { get; set; }

    #region Collections

    #endregion

}
