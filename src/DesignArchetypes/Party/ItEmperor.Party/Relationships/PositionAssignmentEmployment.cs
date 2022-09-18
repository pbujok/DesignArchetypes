using ItEmperor.Party.Organizations;
using ItEmperor.Party.Roles;

namespace ItEmperor.Party.Relationships;

public class PositionAssignmentEmployment : PartyRelationship
{
    protected PositionAssignmentEmployment()
    {
    }

    public PositionAssignmentEmployment(OrganizationPartyRole organizationRole, PersonPartyRole personRole,
        DateTimeOffset startDate, DateTimeOffset? endDate, Position position)
        : base(organizationRole, personRole, startDate, endDate, "Employed person", PartyRelationshipType.Employment)
    {
        Position = position;
    }

    public Position Position { get; private set; }
}