using System;
using System.Collections.Generic;
using ItEmperor.Party.Relationship;

namespace ItEmperor.Party;

public abstract class Party
{
    protected Party()
    {
    }

    public Party(PartyId id, string name)
    {
        Id = id;
        Name = name;
    }

    public PartyId Id { get; }
    
    public string Name { get; }

    public ICollection<TelephoneNumber> TelephoneNumbers { get; private set; } = new List<TelephoneNumber>();

    public ICollection<PartyRelationship> PartyRelationshipsA { get; private set; } = new List<PartyRelationship>();
    
    public ICollection<PartyRelationship> PartyRelationshipsB { get; private set; } = new List<PartyRelationship>();
    
    public void AddRelation(Party relation, string type, DateTimeOffset startDate, DateTimeOffset endDate)
    {
        PartyRelationshipsA.Add(new PartyRelationship(this, relation, startDate, endDate, type));
    }
    
    public void AddTelephone(string name, string telephone)
    {
        TelephoneNumbers.Add(new TelephoneNumber(name, telephone));
    }
}