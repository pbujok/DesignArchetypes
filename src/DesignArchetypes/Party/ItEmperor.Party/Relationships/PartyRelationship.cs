namespace ItEmperor.Party.Relationships;

public class PartyRelationship
{
    public Guid Id { get; private set; }

    public Party PartyA { get; private set; }

    public Party PartyB { get; private set; }

    public DateTimeOffset StartDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }
    
    public string? Comment { get; private set; }

    protected PartyRelationship()
    {
    }

    public PartyRelationship(Party partyA, Party partyB, DateTimeOffset startDate, DateTimeOffset? endDate)
    {
        Id = Guid.NewGuid();
        PartyA = partyA;
        PartyB = partyB;
        StartDate = startDate;
        EndDate = endDate;
        Comment = null;
    }
    
    public PartyRelationship(Party partyA, Party partyB, DateTimeOffset startDate, DateTimeOffset? endDate, string comment)
    {
        Id = Guid.NewGuid();
        PartyA = partyA;
        PartyB = partyB;
        StartDate = startDate;
        EndDate = endDate;
        Comment = comment;
    }
}