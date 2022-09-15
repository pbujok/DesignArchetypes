using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;

namespace ItEmperor.Party.Relationships.Employments;

public class SimpleEmployment : Employment
{
    protected SimpleEmployment()
    {
    }

    public SimpleEmployment(Organization organization, Person person, DateTimeOffset startDate,
        DateTimeOffset? endDate, string postName) : base(organization, person, startDate, endDate)
    {
        PostName = postName;
    }

    public string PostName { get; private set; }
}