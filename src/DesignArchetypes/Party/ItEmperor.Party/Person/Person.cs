using ItEmperor.Party.Address.Simple;
using ItEmperor.Party.Employment.Complex;
using ItEmperor.Party.Employment.Simple;

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

    public ICollection<SimpleEmployment> Employments { get; private set; } = new List<SimpleEmployment>();

    public ICollection<PositionAssignment> PositionAssignments { get; private set; } = new List<PositionAssignment>();
    
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
    
    public void AddSimpleEmployment(Organization.Organization organization, DateTimeOffset from, DateTimeOffset to, string type)
    {
        Employments.Add(new SimpleEmployment()
        {
            Id = Guid.NewGuid(),
            Organization = organization,
            EndDate = to,
            StartDate = from,
            Type = type
        });
    }

    public void AddComplexEmployment(Position position, DateTimeOffset from, DateTimeOffset to)
    {
        PositionAssignments.Add(new PositionAssignment(from, to, position));
    }
}