using System;
using System.Collections.Generic;
using ItEmperor.Party.Address.Simple;
using ItEmperor.Party.Organization;
using ItEmperor.Party.Relationship.Employment;

namespace ItEmperor.Party.Person;

public class Person : Party
{
    protected Person() : base()
    {
    }

    public Person(string firstName, string lastName) : base(PartyId.New(), $"{firstName} {lastName}")
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }
    
    public List<SimpleAddress> Addresses { get; set; } = new List<SimpleAddress>();
    
    public void AddAddress(
        string Text,
        string City,
        string State,
        string PostalCode,
        string Type
    )
    {
        Addresses.Add(new SimpleAddress()
        {
            Id = Guid.NewGuid(),
            City = City,
            PostalCode = PostalCode,
            State = State,
            Text = Text,
            Type = Type
        });
    }
    
    public void AddComplexEmployment(Position position, DateTimeOffset from, DateTimeOffset to)
    {
        PartyRelationshipsA.Add(new PositionAssignmentEmployment(position.Organization, this, from, to, position));
    }
}