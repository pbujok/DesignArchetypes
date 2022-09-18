using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class WarehousePartyRole : OrganizationPartyRole
{
    protected WarehousePartyRole()
    {
    }

    public WarehousePartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party) : base(
        dateFrom, dateTo, party, PartyRoleType.Warehouse)
    {
    }
}