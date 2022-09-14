using System;

namespace ItEmperor.Party.Relationship;

public abstract class PartyRelationship
{
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
    }

    public Guid Id { get; private set; }
    
    public Party PartyA { get; private set; }

    public Party PartyB { get; private set; }

    public DateTimeOffset StartDate { get; private set; }

    public DateTimeOffset? EndDate { get; private set; }
}