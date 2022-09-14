namespace ItEmperor.Party.Relationship.Employment;

public abstract class Employment : PartyRelationship
{
    protected Employment()
    {
        
    }
    public Employment(Organization.Organization organization, Person.Person person, DateTimeOffset startDate,
        DateTimeOffset? endDate) : base(organization, person, startDate, endDate)
    {
    }
}