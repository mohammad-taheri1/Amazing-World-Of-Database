namespace DownTownFloral.Entities;

public class Florist : BaseEntity<long>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
