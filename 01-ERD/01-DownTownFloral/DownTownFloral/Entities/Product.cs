namespace DownTownFloral.Entities;

public class Product : BaseEntity<long>
{
    public string Name { get; set; } = default!;
    public int CurrentPrice { get; set; }
}
