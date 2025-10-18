namespace DownTownFloral.Entities;

public class CustomerToSalesRep : BaseEntity<long>
{
    public long SalesRepId { get; set; }
    public SalesRep SalesRep { get; set; } = new();
    public long CustomerId { get; set; } = default!;
    public Customer Customer { get; set; } = new();
}
