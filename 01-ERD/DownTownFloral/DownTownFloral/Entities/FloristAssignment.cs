namespace DownTownFloral.Entities;

public class FloristAssignment : BaseEntity<long>
{
    public long OrderId { get; set; }
    public Order Order { get; set; } = new();
    public long FloristId { get; set; }
    public Florist Florist { get; set; } = new();
}
