using ItEmperor.Party.Roles.RoleTypes;

namespace ItEmperor.Party.Roles.PartyRoles;

public class EmployerPartyRole : OrganizationPartyRole
{
    protected EmployerPartyRole()
    {
    }

    public EmployerPartyRole(DateTimeOffset dateFrom, DateTimeOffset? dateTo, Party party, PartyRoleType roleType) :
        base(dateFrom, dateTo, party, roleType)
    {
    }
}