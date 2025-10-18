using DownTownFloral.Enums;

namespace DownTownFloral.Entities;

public class Order : BaseEntity<long>
{
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime FulfilledDate { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; } = new();
    public long DriverId { get; set; }
    public Driver Driver { get; set; } = new();
    public string DeliveryAddress { get; set; } = default!;
    public string DeliveryCity { get; set; } = default!;
    public string DeliveryState { get; set; } = default!;
    public string DeliveryZip { get; set; } = default!;
}
