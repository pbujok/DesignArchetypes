using ItEmperor.Party.Addresses.Simple;
using ItEmperor.Party.Classifications;
using ItEmperor.Party.Classifications.Persons;

namespace ItEmperor.Party.Persons;

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

    public void SetSex(DateTimeOffset birthDate, SexPartyType sex)
    {
        PartyClassifications.Add(new PartyClassification(birthDate, null, this, sex));
    }
}