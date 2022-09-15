using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;

namespace ItEmperor.Party.Relationships.Employments;

public abstract class Employment : PartyRelationship
{
    protected Employment()
    {
        
    }
    public Employment(Organization organization, Person person, DateTimeOffset startDate,
        DateTimeOffset? endDate) : base(organization, person, startDate, endDate)
    {
    }
}