namespace ItEmperor.Party.Contact;

public class PartyContactMechanism
{
    public Guid Id { get; init; }

    public ContactMechanism ContactMechanism { get; private set; }

    public Party Party { get; private set; }

    public DateTimeOffset FromDate { get; private set; }

    public DateTimeOffset? ToDate { get; private set; }

    public string? Comment { get; set; }

    protected PartyContactMechanism()
    {
    }

    public PartyContactMechanism(ContactMechanism contactMechanism, Party party,
        DateTimeOffset fromDate, DateTimeOffset? toDate)
    {
        Id = Guid.NewGuid();
        ContactMechanism = contactMechanism;
        Party = party;
        FromDate = fromDate;
        ToDate = toDate;
    }
}