using DownTownFloral.Enums;

namespace DownTownFloral.Entities;

public class Order : BaseEntity<long>
{
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime FulfilledDate { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
}
