using ItEmperor.Party.Roles;

namespace ItEmperor.Party.Relationships;

public class RetailSalesPartyRelationship : PartyRelationship
{
    protected RetailSalesPartyRelationship()
    {
    }

    public RetailSalesPartyRelationship(OrganizationPartyRole from, OrganizationPartyRole to, DateTimeOffset startDate, DateTimeOffset? endDate,
        string comment) 
        : base(from, to, startDate, endDate, comment, PartyRelationshipType.Customer)
    {
    }
}