using ItEmperor.Party.Roles;

namespace ItEmperor.Party.Relationships;

public class CustomerPartyRelationship : PartyRelationship
{
    protected CustomerPartyRelationship()
    {
    }

    public CustomerPartyRelationship(PartyRole from, OrganizationPartyRole to, DateTimeOffset startDate, DateTimeOffset? endDate,
        string comment) 
        : base(from, to, startDate, endDate, comment, PartyRelationshipType.Customer)
    {
    }
}