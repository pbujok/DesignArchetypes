using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class CustomerPartyRole : PartyRole
{
    protected CustomerPartyRole()
    {
    }

    public CustomerPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party) :
        base(dateFrom, dateTo, party, PartyRoleType.Customer)
    {
    }
}