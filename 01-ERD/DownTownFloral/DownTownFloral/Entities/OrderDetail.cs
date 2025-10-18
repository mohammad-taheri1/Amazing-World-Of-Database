namespace DownTownFloral.Entities;

public class OrderDetail : BaseEntity<long>
{
    public long OrderId { get; set; }
    public Order Order { get; set; }
    public long ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int OrderTimeUnitPrice { get; set; }
}
