using ItEmperor.Party.Persons;

namespace ItEmperor.Party.Organizations;

public class SimpleEmployment
{
    public Guid Id { get; init; }

    public Organization Organization { get; }

    public Person Person { get; }
    
    public DateTimeOffset StartDate { get; }
    
    public DateTimeOffset? EndDate { get; }

    public string PostName { get; private set; }


    protected SimpleEmployment()
    {
    }

    public SimpleEmployment(Organization organization, Person person,
        DateTimeOffset startDate, DateTimeOffset? endDate, string postName)
    {
        Id = Guid.NewGuid();
        Organization = organization;
        Person = person;
        StartDate = startDate;
        EndDate = endDate;
        PostName = postName;
    }
}