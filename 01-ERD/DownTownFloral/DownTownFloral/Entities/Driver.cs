namespace DownTownFloral.Entities;

public class Driver : BaseEntity<long>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Mobile { get; set; } = default!;
    public long Zone { get; set; } // TODO: Enum ? String? Need more details
    public DateTime LicenseExpiryDateTime { get; set; }
}
