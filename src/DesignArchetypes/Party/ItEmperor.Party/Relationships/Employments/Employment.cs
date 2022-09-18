using ItEmperor.Party.Roles.PartyRoles;

namespace ItEmperor.Party.Relationships.Employments;

public abstract class Employment : PartyRelationship
{
    protected Employment()
    {
    }

    public Employment(OrganizationPartyRole organizationRole, PersonPartyRole personRole, DateTimeOffset startDate,
        DateTimeOffset? endDate) : base(organizationRole,
        personRole,
        startDate,
        endDate,
        "Employed person",
        PartyRelationshipType.Employment)
    {
    }
}