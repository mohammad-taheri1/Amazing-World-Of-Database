namespace DownTownFloral;

public class BaseEntity<T>
{
    protected T Id { get; set; }
    protected bool Deleted { get; set; }
    protected DateTime CreatedAt { get; set; }
    protected Guid CreatedBy { get; set; }
    protected DateTime UpdatedAt { get; set; }
    protected Guid UpdatedBy { get; set; }
}
