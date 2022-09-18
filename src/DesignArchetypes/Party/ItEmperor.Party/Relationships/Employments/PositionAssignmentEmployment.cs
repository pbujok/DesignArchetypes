using ItEmperor.Party.Organizations;
using ItEmperor.Party.Roles.PartyRoles;

namespace ItEmperor.Party.Relationships.Employments;

public class PositionAssignmentEmployment : Employment
{
    protected PositionAssignmentEmployment()
    {
    }

    public PositionAssignmentEmployment(OrganizationPartyRole organizationRole, PersonPartyRole personRole,
        DateTimeOffset startDate, DateTimeOffset? endDate, Position position) : base(organizationRole, personRole, startDate, endDate)
    {
        Position = position;
    }
    
    public Position Position { get; private set; }
}