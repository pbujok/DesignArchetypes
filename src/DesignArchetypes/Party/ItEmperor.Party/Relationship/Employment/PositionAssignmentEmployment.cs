using ItEmperor.Party.Organization;

namespace ItEmperor.Party.Relationship.Employment;

public class PositionAssignmentEmployment : Employment
{
    protected PositionAssignmentEmployment()
    {
    }

    public PositionAssignmentEmployment(Organization.Organization organization, Person.Person person,
        DateTimeOffset startDate, DateTimeOffset? endDate, Position position) : base(organization, person, startDate, endDate)
    {
        Position = position;
    }
    
    public Position Position { get; private set; }
}