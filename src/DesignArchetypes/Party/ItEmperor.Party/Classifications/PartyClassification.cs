namespace ItEmperor.Party.Classifications;

public class PartyClassification
{
    public Guid Id { get; init; }
    public DateTimeOffset FromDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }

    public Party Party { get; private set; }

    public PartyType Type { get; private set; }

    protected PartyClassification()
    {
    }

    public PartyClassification(DateTimeOffset fromDate, DateTimeOffset? endDate, Party party, PartyType type)
    {
        Id = Guid.NewGuid();
        FromDate = fromDate;
        EndDate = endDate;
        Party = party;
        Type = type;
    }
}