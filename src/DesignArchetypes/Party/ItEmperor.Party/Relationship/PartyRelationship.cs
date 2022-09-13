using System;

namespace ItEmperor.Party.Relationship;

public class PartyRelationship
{
    protected PartyRelationship()
    {
        
    }

    public PartyRelationship(Party partyA, Party partyB, DateTimeOffset startDate, DateTimeOffset? endDate, string type)
    {
        Id = Guid.NewGuid();
        PartyA = partyA;
        PartyB = partyB;
        StartDate = startDate;
        EndDate = endDate;
        Type = type;
    }

    public Guid Id { get; private set; }
    
    public Party PartyA { get; private set; }

    public Party PartyB { get; private set; }

    public DateTimeOffset StartDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }
    
    public string Type { get; private set; }
}