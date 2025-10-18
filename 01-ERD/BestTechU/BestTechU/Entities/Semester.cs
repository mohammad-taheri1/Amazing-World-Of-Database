namespace BestTechU.Entities;

public class Semester : BaseEntity<long>
{
    public string Title { get; set; } = default!;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    #region Collections

    public ICollection<Class> Classes { get; set; } = [];

    #endregion

}
