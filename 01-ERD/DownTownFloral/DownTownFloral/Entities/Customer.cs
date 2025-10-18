namespace DownTownFloral.Entities;

public class Customer : BaseEntity<long>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string OrderPhone { get; set; }
    public string MailingAddress { get; set; }
    public string MailingCity { get; set; }
    public string MailingState { get; set; }
    public string MailingZip { get; set; }
    public string EmailAddress { get; set; }
}
