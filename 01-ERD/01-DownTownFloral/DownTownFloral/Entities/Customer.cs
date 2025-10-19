namespace DownTownFloral.Entities;

public class Customer : BaseEntity<long>
{
    public string FirstName { get; set; } = default!;
    public string MiddleName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string OrderPhone { get; set; } = default!;
    public string MailingAddress { get; set; } = default!;
    public string MailingCity { get; set; } = default!;
    public string MailingState { get; set; } = default!;
    public string MailingZip { get; set; } = default!;
    public string EmailAddress { get; set; } = default!;
}
