using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles;

public class OrganizationPartyRole : PartyRole
{
    protected OrganizationPartyRole()
    {
    }

    public OrganizationPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party, PartyRoleType roleType) :
        base(dateFrom, dateTo, party, roleType)
    {
    }
}