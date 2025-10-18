namespace DownTownFloral.Entities;

public class Product : BaseEntity<long>
{
    public string Name { get; set; }
    public int CurrentPrice { get; set; }
}
