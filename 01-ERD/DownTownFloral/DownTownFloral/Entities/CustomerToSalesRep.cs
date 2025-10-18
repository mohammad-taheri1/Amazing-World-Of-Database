namespace DownTownFloral.Entities;

public class CustomerToSalesRep : BaseEntity<long>
{
    public long SalesRepId { get; set; }
    public SalesRep SalesRep { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
}
