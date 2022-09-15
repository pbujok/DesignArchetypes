using System;
using System.Collections.Generic;
using ItEmperor.Party.Classifications;

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
    
    public ICollection<PartyClassification> PartyClassifications { get; private set; } =
        new List<PartyClassification>();

    public void AddTelephone(string name, string telephone)
    {
        TelephoneNumbers.Add(new TelephoneNumber(name, telephone));
    }
}