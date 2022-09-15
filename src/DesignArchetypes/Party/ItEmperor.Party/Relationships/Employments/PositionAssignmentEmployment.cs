using ItEmperor.Party.Organizations;
using ItEmperor.Party.Persons;

namespace ItEmperor.Party.Relationships.Employments;

public class PositionAssignmentEmployment : Employment
{
    protected PositionAssignmentEmployment()
    {
    }

    public PositionAssignmentEmployment(Organization organization, Person person,
        DateTimeOffset startDate, DateTimeOffset? endDate, Position position) : base(organization, person, startDate, endDate)
    {
        Position = position;
    }
    
    public Position Position { get; private set; }
}