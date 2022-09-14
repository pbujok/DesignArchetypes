namespace ItEmperor.Party.Relationship.Employment;

public class SimpleEmployment : Employment
{
    protected SimpleEmployment()
    {
    }

    public SimpleEmployment(Organization.Organization organization, Person.Person person, DateTimeOffset startDate,
        DateTimeOffset? endDate, string postName) : base(organization, person, startDate, endDate)
    {
        PostName = postName;
    }

    public string PostName { get; private set; }
}