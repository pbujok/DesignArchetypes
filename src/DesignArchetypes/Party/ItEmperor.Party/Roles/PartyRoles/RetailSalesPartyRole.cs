using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class RetailSalesPartyRole : OrganizationPartyRole
{
    protected RetailSalesPartyRole()
    {
    }

    public RetailSalesPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party) :
        base(dateFrom, dateTo, party, PartyRoleType.RetailSales)
    {
    }
}